using DevExpress.LookAndFeel;
using DevExpress.Skins;
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
            UserLookAndFeel.Default.SkinName = skinName;
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
                var commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
                DevExpress.Utils.Svg.SvgPalette customPallete = commonSkin.SvgPalettes[Skin.DefaultSkinPaletteName].CustomPalette;
                var name = commonSkin.CustomSvgPalettes.FirstOrDefault(x => x.Value == customPallete).Key?.Name;
                Settings.Default["Palette"] = name;
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
                SetSkin(Settings.Default["SkinName"].ToString());
            else
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier);
            if (UserLookAndFeel.Default.SkinName == "The Bezier")
            {
                if (Settings.Default["Palette"] != null && Settings.Default["Palette"].ToString() != string.Empty)
                {
                    var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
                    DevExpress.Utils.Svg.SvgPalette palette = skin.CustomSvgPalettes[Settings.Default["Palette"].ToString()];
                    if (palette != null)
                    {
                        skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
                        LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
                    }
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RestorePalette();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavePalette();
        }
    }
}
