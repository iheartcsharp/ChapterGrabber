﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JarrettVance.ChapterTools.Properties;

namespace JarrettVance.ChapterTools
{
    public partial class SearchResultItem : UserControl
    {
        public event EventHandler OnSelected;
        private bool selected;
        //private Brush relBrush;
        private readonly Color green = Color.FromArgb(0x46, 0x88, 0x47);
        private readonly Color red = Color.FromArgb(0xB9, 0x4A, 0x48);

        public bool Selected { get { return selected; } }

        public SearchResultItem()
        {
            InitializeComponent();
            //
            //using (var font = FontHelper.Create("FontAwesome", 12))
            //{
            //    lblHasNames.Font = font;
            //    lblArrow.Font = font;
            //}
        }

        public SearchResultItem(SearchResult search)
        {
            InitializeComponent();
            this.Tag = search;

            lblName.Text = search.Name;

            if (search.Type != "Unknown")
            {
                lblSourceType.Text = search.Type;
            }
            else
            {
                lblSourceType.Text = string.Empty;
            }

            if (search.Duration != TimeSpan.Zero)
            {
                lblDuration.Text = search.Duration.ToShorterString();
            }
            else
            {
                lblDuration.Text = string.Empty;
            }

            lblCount.Text = string.Format("{0} chapters", search.Count);

            lblRelevance.Text = search.Relevance.ToString();
            //lblRelevance.BackColor = Color.Transparent;
            if (search.Relevance >= 8)
            {
                lblRelevance.ForeColor = green;
                //relBrush = new SolidBrush(green);
            }
            else if (search.Relevance >= 4)
            {
                //relBrush = new SolidBrush(Color.Orange);
                lblRelevance.ForeColor = Color.Orange;
            }
            else
            {
                //relBrush =new SolidBrush(Color.Gray);
                lblRelevance.ForeColor = Color.LightGray;
            }

            if (!search.HasNames.HasValue)
            {
                lblHasNames.Text = "";
                lblHasNames.ForeColor = Color.LightGray;
            }
            else if (!search.HasNames.Value)
            {
                lblHasNames.Text = "";//#b94a48
                lblHasNames.ForeColor = red;
            }
            else
            {
                lblHasNames.Text = "";
                lblHasNames.ForeColor = Color.Green;
            }
        }

        public new void Select()
        {
            selected = true;
            this.AlterView();
            if (this.OnSelected != null)
            {
                this.OnSelected(this, EventArgs.Empty);
            }
        }

        public void Unselect()
        {
            selected = false;
            this.AlterView();
        }

        private void AlterView()
        {
            lblName.ForeColor = selected ? SystemColors.MenuHighlight : SystemColors.WindowText;
            lblSourceType.ForeColor = selected ? SystemColors.MenuHighlight : SystemColors.GrayText;
            lblDuration.ForeColor = selected ? SystemColors.MenuHighlight : SystemColors.GrayText;
            lblCount.ForeColor = selected ? SystemColors.MenuHighlight : SystemColors.GrayText;
            //this.BackColor = selected ? System.Drawing.SystemColors.MenuBar : System.Drawing.SystemColors.Window;
            this.lblArrow.Visible = selected;
        }

        private void SearchResultItem_Click(object sender, EventArgs e)
        {
            this.Select();
        }

        private void SearchResultItem_Load(object sender, EventArgs e)
        {

        }

        private void this_Paint(object sender, PaintEventArgs e)
        {
            //var path = RoundedRectangle.Create(lblRelevance.Left, lblRelevance.Top, lblRelevance.Width, lblRelevance.Height, 3, RoundedRectangle.RectangleCorners.All);
            //e.Graphics.FillPath(relBrush, path);
            //var rect = new Rectangle(lblRelevance.Location, lblRelevance.Size);
            //rect.Offset(0, -1);
            //Helpers.FillRoundedRectangle(e.Graphics, rect, relBrush, 2);
        }
    }
}
