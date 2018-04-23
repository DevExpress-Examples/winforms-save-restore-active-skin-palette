using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DXApplication1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePalette();
        }

        private void SetSkin(string skinName)
        {
            UserLookAndFeel.Default.SetSkinStyle(skinName);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowSwatchPicker(this);
        }

        private void ShowSwatchPicker(Form owner)
        {
            using (var dialog = new DevExpress.Customization.SvgSkinPaletteSelector(owner))
            {
                dialog.ShowDialog();
                SavePalette();
            }
        }

        private void SavePalette()
        {
            Settings.Default["SkinName"] = UserLookAndFeel.Default.SkinName;
            if (UserLookAndFeel.Default.SkinName == "The Bezier")
            {
                Settings.Default["Palette"] = UserLookAndFeel.Default.ActiveSvgPaletteName;
            }
            Settings.Default.Save();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RestorePalette();
        }
        
        private void RestorePalette()
        {
            if (Settings.Default["SkinName"] != null && Settings.Default["SkinName"].ToString() != string.Empty)
            {
                if (Settings.Default["SkinName"].ToString() == "The Bezier" && Settings.Default["Palette"] != null && Settings.Default["Palette"].ToString() != string.Empty)
                {
                    UserLookAndFeel.Default.SetSkinStyle(Settings.Default["SkinName"].ToString(), Settings.Default["Palette"].ToString());
                }
                else
                    SetSkin(Settings.Default["SkinName"].ToString());

            }
            else if (Settings.Default["Palette"] != null && Settings.Default["Palette"].ToString() != string.Empty)
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, Settings.Default["Palette"].ToString());
            }
        }
    }
}
