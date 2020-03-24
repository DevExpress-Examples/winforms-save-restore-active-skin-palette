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
        public Form1() {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            SavePalette();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ShowSwatchPicker(this);
        }

        private void ShowSwatchPicker(Form owner) {
            using(var dialog = new DevExpress.Customization.SvgSkinPaletteSelector(owner)) {
                dialog.ShowDialog();
                SavePalette();
            }
        }

        private void SavePalette() {
            var settings = Properties.Settings.Default;
            settings.SkinName = UserLookAndFeel.Default.SkinName;
            settings.Palette = UserLookAndFeel.Default.ActiveSvgPaletteName;
            settings.Save();
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            RestorePalette();
        }

        private void RestorePalette() {
            var settings = Properties.Settings.Default;
            if(!String.IsNullOrEmpty(settings.SkinName)) {
                if(!String.IsNullOrEmpty(settings.SkinName)) {
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName, settings.Palette);
                }
                else
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName);
            }
        }
    }
}
