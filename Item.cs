using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaBilder {
    public class Item {
        private string name;
        private Image img;

        public Item(string name) {
            this.name = name;
            set_img(name);
        }
        public Item(int num) {
            this.name = get_name(num);
            set_img(num);
        }

        public static string get_name(int num) {
            string name = "123";
            switch (num) {
                case 0: name = "Hand of Midas"; break;
                case 1: name = "Arcane Boots"; break;
                case 2: name = "Power Treads"; break;
                case 3: name = "Phase Boots"; break;
                case 4: name = "Guardian Greaves"; break;
                case 5: name = "Boots of Travel"; break;
                case 6: name = "Boots of Bearing"; break;
                case 7: name = "Holy Locket"; break;
                case 8: name = "Pipe of Insight"; break;
                case 9: name = "Bloodthorn"; break;
                case 10: name = "Moon Shard"; break;
                case 11: name = "Spirit Vessel"; break;
                case 12: name = "Wraith Pact"; break;
                case 13: name = "Crimson Guard"; break;
                case 14: name = "Helm of the Overlord"; break;
                case 15: name = "Heart of Tarrasque"; break;
                case 16: name = "Eternal Shroud"; break;
                case 17: name = "Dagon"; break;
                case 18: name = "Aeon Disk"; break;
                case 19: name = "Glimmer Cape"; break;
                case 20: name = "Veil of Discord"; break;
                case 21: name = "Shiva's Guard"; break;
                case 22: name = "Black King Bar"; break;
                case 23: name = "Hurricane Pike"; break;
                case 24: name = "Manta Style"; break;
                case 25: name = "Lotus Orb"; break;
                case 26: name = "Linken's Sphere"; break;
                case 27: name = "Assault Cuirass"; break;
                case 28: name = "Solar Crest"; break;
                case 29: name = "Octarine Core"; break;
                case 30: name = "Scythe of Vyse"; break;
                case 31: name = "Gleipnir"; break;
                case 32: name = "Aghanim's Scepter"; break;
                case 33: name = "Refresher Orb"; break;
                case 34: name = "Bloodstone"; break;
                case 35: name = "Meteor Hammer"; break;
                case 36: name = "Wind Waker"; break;
                case 37: name = "Swift Blink"; break;
                case 38: name = "Arcane Blink"; break;
                case 39: name = "Overwhelming Blink"; break;
                case 40: name = "Diffusal Blade"; break;
                case 41: name = "Mage Slayer"; break;
                case 42: name = "Armlet of Mordiggian"; break;
                case 43: name = "Echo Sabre"; break;
                case 44: name = "Satanic"; break;
                case 45: name = "Eye of Skadi"; break;
                case 46: name = "Kaya and Sange"; break;
                case 47: name = "Sange and Yasha"; break;
                case 48: name = "Yasha and Kaya"; break;
                case 49: name = "Abyssal Blade"; break;
                case 50: name = "Revenant's Brooch"; break;
                case 51: name = "Mjollnir"; break;
                case 52: name = "Heaven's Halberd"; break;
                case 53: name = "Battle Fury"; break;
                case 54: name = "Ethereal Blade"; break;
                case 55: name = "Desolator"; break;
                case 56: name = "Nullifier"; break;
                case 57: name = "Monkey King Bar"; break;
                case 58: name = "Butterfly"; break;
                case 59: name = "Radiance"; break;
                case 60: name = "Daedalus"; break;
                case 61: name = "Silver Edge"; break;
                case 62: name = "Divine Rapier"; break;
            }
            return name;
        }
        public static int get_num(string name) {
            int num = 0;
            switch (name) {
                case "Hand of Midas": num = 0; break;
                case "Arcane Boots": num = 1; break;
                case "Power Treads": num = 2; break;
                case "Phase Boots": num = 3; break;
                case "Guardian Greaves": num = 4; break;
                case "Boots of Travel": num = 5; break;
                case "Boots of Bearing": num = 6; break;
                case "Holy Locket": num = 7; break;
                case "Pipe of Insight": num = 8; break;
                case "Bloodthorn": num = 9; break;
                case "Moon Shard": num = 10; break;
                case "Spirit Vessel": num = 11; break;
                case "Wraith Pact": num = 12; break;
                case "Crimson Guard": num = 13; break;
                case "Helm of the Overlord": num = 14; break;
                case "Heart of Tarrasque": num = 15; break;
                case "Eternal Shroud": num = 16; break;
                case "Dagon": num = 17; break;
                case "Aeon Disk": num = 18; break;
                case "Glimmer Cape": num = 19; break;
                case "Veil of Discord": num = 20; break;
                case "Shiva's Guard": num = 21; break;
                case "Black King Bar": num = 22; break;
                case "Hurricane Pike": num = 23; break;
                case "Manta Style": num = 24; break;
                case "Lotus Orb": num = 25; break;
                case "Linken's Sphere": num = 26; break;
                case "Assault Cuirass": num = 27; break;
                case "Solar Crest": num = 28; break;
                case "Octarine Core": num = 29; break;
                case "Scythe of Vyse": num = 30; break;
                case "Gleipnir": num = 31; break;
                case "Aghanim's Scepter": num = 32; break;
                case "Refresher Orb": num = 33; break;
                case "Bloodstone": num = 34; break;
                case "Meteor Hammer": num = 35; break;
                case "Wind Waker": num = 36; break;
                case "Swift Blink": num = 37; break;
                case "Arcane Blink": num = 38; break;
                case "Overwhelming Blink": num = 39; break;
                case "Diffusal Blade": num = 40; break;
                case "Mage Slayer": num = 41; break;
                case "Armlet of Mordiggian": num = 42; break;
                case "Echo Sabre": num = 43; break;
                case "Satanic": num = 44; break;
                case "Eye of Skadi": num = 45; break;
                case "Kaya and Sange": num = 46; break;
                case "Sange and Yasha": num = 47; break;
                case "Yasha and Kaya": num = 48; break;
                case "Abyssal Blade": num = 49; break;
                case "Revenant's Brooch": num = 50; break;
                case "Mjollnir": num = 51; break;
                case "Heaven's Halberd": num = 52; break;
                case "Battle Fury": num = 53; break;
                case "Ethereal Blade": num = 54; break;
                case "Desolator": num = 55; break;
                case "Nullifier": num = 56; break;
                case "Monkey King Bar": num = 57; break;
                case "Butterfly": num = 58; break;
                case "Radiance": num = 59; break;
                case "Daedalus": num = 60; break;
                case "Silver Edge": num = 61; break;
                case "Divine Rapier": num = 62; break;
            }
            return num;
        }
        private void set_img(int num) {
            int y = num / 7;
            int x = num % 7;

            Image source_img = Image.FromFile("Resources\\items.png");
            Image bitmap = new Bitmap(48, 35, source_img.PixelFormat);
            Graphics graphics = Graphics.FromImage(bitmap);


            Rectangle source_rect = new Rectangle(0, 0, 48, 35);
            graphics.DrawImage(source_img, source_rect, x * 48, y * 35, 48, 35, GraphicsUnit.Pixel);
            img = bitmap;
        }
        private void set_img(string name) {
            set_img(get_num(name));
        }
        public Image get_img() {
            return img;
        }
        public string get_name() {
            return name;
        }

    }
}
