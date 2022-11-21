using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaBilder {
    public partial class Items : Form {

        int[] banned_items = new int[3];
        string mode;
        int count = 0;

        Random rnd = new Random();
        Button[] arr = new Button[63];
        public Items(string mode) {
            this.mode = mode;
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e) {
            Item itm;
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 7; j++) {
                    itm = new Item(i * 7 + j);
                    arr[i * 7 + j] = new Button();
                    arr[i * 7 + j].Size = new Size(96, 70);
                    arr[i * 7 + j].Location = new Point(96 * j, 70 * i);
                    arr[i * 7 + j].BackgroundImageLayout = ImageLayout.Stretch;
                    arr[i * 7 + j].FlatStyle = FlatStyle.Flat;
                    arr[i * 7 + j].FlatAppearance.BorderSize = 1;
                    arr[i * 7 + j].BackgroundImage = itm.get_img();
                    arr[i * 7 + j].Name = Item.get_name(i * 7 + j);
                    arr[i * 7 + j].Click += new EventHandler(OnItemPress);
                    this.Controls.Add(arr[i * 7 + j]);
                }
            }
        }

        public void OnItemPress(object sender, EventArgs e) {
            Form1 main = this.Owner as Form1;
            Button btn = sender as Button;

            if (main != null) {
                if(mode == "ban")
                    main.banned_items[count] = new Item(btn.Name);
                else
                    main.selected_items[count] = new Item(btn.Name);
                count++;
            }
            Image source_img;
            if (mode == "ban")
                source_img = Image.FromFile("Resources\\cross.png");
            else
                source_img = Image.FromFile("Resources\\add.png");
            Image bitmap = btn.BackgroundImage;
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.DrawImage(source_img, 0, 0);
            btn.BackgroundImage = bitmap;
            if (count == 3) {
                if(mode != "ban") main.refresh_selected();
                this.Close();
            }
            
        }
    }
}
