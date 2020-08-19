using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AnyCAD.Platform;
using System.IO;

namespace AnyCAD.Basic
{
    public partial class FormMain : Form
    {
        // Render Control
        private Presentation.RenderWindow3d renderView;
        private int shapeId = 100;


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sTLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "STL (*.stl)|*.stl|IGES (*.igs;*.iges)|*.igs;*.iges|STEP (*.stp;*.step)|*.stp;*.step|BREP (*.brep)|*.brep|All Files(*.*)|*.*";

            if (DialogResult.OK != dlg.ShowDialog())
                return;


            TopoShape shape = GlobalInstance.BrepTools.LoadFile(new AnyCAD.Platform.Path(dlg.FileName));
            renderView.RenderTimer.Enabled = false;
            if (shape != null)
            {
                TopoShapeGroup group = new TopoShapeGroup();
                group.Add(shape);
                SceneManager sceneMgr = renderView.SceneManager;
                SceneNode rootNode = GlobalInstance.TopoShapeConvert.ToSceneNode(shape, 0.1f);
                if (rootNode != null)
                {
                    sceneMgr.AddNode(rootNode);
                }
            }
            renderView.RenderTimer.Enabled = true;


            renderView.FitAll();
            renderView.RequestDraw(EnumRenderHint.RH_LoadScene);
        }

        private void sTEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "STEP (*.stp;*.step)|*.stp;*.step|All Files(*.*)|*.*";

            if (DialogResult.OK != dlg.ShowDialog())
                return;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Image File(*.png;*.jpg)|*.png;*.jpg|All Files(*.*)|*.*";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                renderView.CaptureImage(dlg.FileName);
            }
        }

        private void shadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.SetDisplayMode((int)(EnumDisplayStyle.DS_Face | EnumDisplayStyle.DS_Realistic));
        }

        private void shadeWithEdgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.SetDisplayMode((int)(EnumDisplayStyle.DS_Face | EnumDisplayStyle.DS_Edge | EnumDisplayStyle.DS_Realistic));
        }

        private void edgeWithPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.SetDisplayMode((int)(EnumDisplayStyle.DS_Edge | EnumDisplayStyle.DS_Vertex));
        }

        private void orbitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.ExecuteCommand("Orbit");
        }

        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.ExecuteCommand("Pan");
        }

        private bool mShowGrid = true;
        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mShowGrid = !mShowGrid;
            renderView.ShowWorkingGrid(mShowGrid);
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.Renderer.SetStandardView(EnumStandardView.SV_Top);
            renderView.RequestDraw();
        }

        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.Renderer.SetStandardView(EnumStandardView.SV_Front);
            renderView.RequestDraw();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 清除视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.ClearScene();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (renderView != null)
            {

                System.Drawing.Size size = this.panel1.ClientSize;
                renderView.Size = size;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            this.renderView = new AnyCAD.Presentation.RenderWindow3d();
            System.Drawing.Size size = this.panel1.ClientSize;
            this.renderView.Size = size;

            this.renderView.TabIndex = 1;
            this.panel1.Controls.Add(this.renderView);

            this.renderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRenderWindow_MouseClick);

            GlobalInstance.EventListener.OnChangeCursorEvent += OnChangeCursor;
            GlobalInstance.EventListener.OnSelectElementEvent += OnSelectElement;
        }

        private void OnSelectElement(SelectionChangeArgs args)
        {
            if (!args.IsHighlightMode())
            {
                SelectedShapeQuery query = new SelectedShapeQuery();
                renderView.QuerySelection(query);
                var shape = query.GetGeometry();
                if (shape != null)
                {
                    GeomCurve curve = new GeomCurve();
                    if (curve.Initialize(shape))
                    {
                        TopoShapeProperty property = new TopoShapeProperty();
                        property.SetShape(shape);
                        Console.WriteLine("Edge Length {0}", property.EdgeLength());
                    }
                }
            }
        }

        private void OnChangeCursor(String commandId, String cursorHint)
        {

            if (cursorHint == "Pan")
            {
                this.renderView.Cursor = System.Windows.Forms.Cursors.SizeAll;
            }
            else if (cursorHint == "Orbit")
            {
                this.renderView.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else if (cursorHint == "Cross")
            {
                this.renderView.Cursor = System.Windows.Forms.Cursors.Cross;
            }
            else
            {
                if (commandId == "Pick")
                {
                    this.renderView.Cursor = System.Windows.Forms.Cursors.Arrow;
                }
                else
                {
                    this.renderView.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }

        }

        private bool m_PickPoint = false;
        private void pickPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_PickPoint = !m_PickPoint;
        }
        private void OnRenderWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (!m_PickPoint)
                return;

            Platform.PickHelper pickHelper = renderView.PickShape(e.X, e.Y);
            if (pickHelper != null)
            {

            }

            Vector3 pt = renderView.HitPointOnGrid(e.X, e.Y);
            if (pt != null)
            {

            }
        }


    }
}