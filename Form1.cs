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
    public partial class Form1 : Form {

        string[] pool_pos1 = new string[] { "Primal Beast", "Storm Spirit", "Zeus", "Pugna", "Void Spirit", "Ember Spirit", "Arc Warden", "Leshrac", "Lina", "Invoker", "Venomancer" };
        string[] pool_pos3 = new string[] { "Silencer", "Skywrath Mage", "Techies", "Jakiro", "Phantom Assassin", "Sand King", "Death Prophet", "Dragon Knight", "Night Stalker" };
        string[] pool_pos4 = new string[] { "Dark Willow", "Ancient Apparition", "Viper", "Windranger", "Keeper of the Light", "Mirana", "Enchantres", "Hoodwink", "Rubick", "Io", "Nature`s Prophet" };
        public Item[] banned_items = new Item[3];
        public Item[] selected_items = new Item[3];
        private Item[] random_items = new Item[3];

        string curr_hero;
        Random random = new Random();
        enum Position {one, three, four };
        Position position;


        public Form1() {
            InitializeComponent();
        }

        private void Select_pos_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            switch (btn.Name) {
                case "select_pos1": position = Position.one; break;
                case "select_pos3": position = Position.three; break;
                case "select_pos4": position = Position.four; break;
            }
            button_hero_Click(sender, e);
        }

        private void button_hero_Click(object sender, EventArgs e) {
            string hero = "Primal Beast";
            if (position == Position.three) {
                if (button_hero.BackgroundImage == null) {
                    hero = pool_pos3[random.Next(0, pool_pos3.Length)];
                }
                else do {
                        hero = pool_pos3[random.Next(0, pool_pos3.Length)];
                    } while (hero == curr_hero);
            }
            if (position == Position.one) {
                if (button_hero.BackgroundImage == null) {
                    hero = pool_pos1[random.Next(0, pool_pos1.Length)];
                }
                else do {
                        hero = pool_pos1[random.Next(0, pool_pos1.Length)];
                    } while (hero == curr_hero);
            }
            if (position == Position.four) {
                if (button_hero.BackgroundImage == null) {
                    hero = pool_pos4[random.Next(0, pool_pos4.Length)];
                }
                else do {
                        hero = pool_pos4[random.Next(0, pool_pos4.Length)];
                    } while (hero == curr_hero);
            }
            curr_hero = hero;
            Hero tmp = new Hero(hero);
            button_hero.BackgroundImage = tmp.get_img();
        }

        private void button_ban_Click(object sender, EventArgs e) {
            Items form = new Items("ban");
            form.Owner = this;
            form.Show();
        }

        private void button_select_items_Click(object sender, EventArgs e) {
            Items form = new Items("add");
            form.Owner = this;
            form.Show();

        }

        public void refresh_selected() {
            button_item1.BackgroundImage = selected_items[0].get_img();
            button_item2.BackgroundImage = selected_items[1].get_img();
            button_item3.BackgroundImage = selected_items[2].get_img();
        }

        private void button_build_Click(object sender, EventArgs e) {
            Item random_item;
            bool isOnce = true;
            for(int k = 0; k < 3; k++) {
                random_item = new Item(random.Next(0,63));
                foreach (Item item in banned_items)
                    if(item.get_name() == random_item.get_name()) {
                        isOnce = false; break;
                    }
                foreach (Item item in selected_items)
                    if (item.get_name() == random_item.get_name()) {
                        isOnce = false; break;
                    }
                
                if (isOnce) random_items[k] = random_item;
            }
            button_item4.BackgroundImage = random_items[0].get_img();
            button_item5.BackgroundImage = random_items[1].get_img();
            button_item6.BackgroundImage = random_items[2].get_img();
        }
    }
}
