using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaBilder {
    internal class Hero {

        private string name;
        private Image img;

        public Hero(string name) {
            this.name = name;
            set_img(name);

        }

        public Image get_img() {
            return img;
        }
        private void set_img(string name) {
            int num = 0;

            switch (name) {
                case "Abaddon":
                    num = 0;
                    break;
                case "Alchemist":
                    num = 1;
                    break;
                case "Ancient Apparition":
                    num = 2;
                    break;
                case "Anti-Mage":
                    num = 3;
                    break;
                case "Arc Warden":
                    num = 4;
                    break;
                case "Axe":
                    num = 5;
                    break;
                case "Bane":
                    num = 6;
                    break;
                case "Batrider":
                    num = 7;
                    break;
                case "Beastmaster":
                    num = 8;
                    break;
                case "Bloodseeker":
                    num = 9;
                    break;
                case "Bounty Hunter":
                    num = 10;
                    break;
                case "Brewmaster":
                    num = 11;
                    break;
                case "Bristleback":
                    num = 12;
                    break;
                case "Broodmother":
                    num = 13;
                    break;
                case "Centaur Warrunner":
                    num = 14;
                    break;
                case "ChaosKnight":
                    num = 15;
                    break;
                case "Chen":
                    num = 16;
                    break;
                case "Clinkz":
                    num = 17;
                    break;
                case "Clockwerk":
                    num = 18;
                    break;
                case "CrystalMaiden":
                    num = 19;
                    break;
                case "DarkSeer":
                    num = 20;
                    break;
                case "Dark Willow":
                    num = 21;
                    break;
                case "Dawnbreaker":
                    num = 22;
                    break;
                case "Dazzle":
                    num = 23;
                    break;
                case "DeathProphet":
                    num = 24;
                    break;
                case "Disruptor":
                    num = 25;
                    break;
                case "Doom":
                    num = 26;
                    break;
                case "Dragon Knight":
                    num = 27;
                    break;
                case "Drow Ranger":
                    num = 28;
                    break;
                case "Earth Spirit":
                    num = 29;
                    break;
                case "Earthshaker":
                    num = 30;
                    break;
                case "Elder Titan":
                    num = 31;
                    break;
                case "Ember Spirit":
                    num = 32;
                    break;
                case "Enchantres":
                    num = 33;
                    break;
                case "Enigma":
                    num = 34;
                    break;
                case "Faceless Void":
                    num = 35;
                    break;
                case "Grimstroke":
                    num = 36;
                    break;
                case "Gyrocopter":
                    num = 37;
                    break;
                case "Hoodwink":
                    num = 38;
                    break;
                case "Huskar":
                    num = 39;
                    break;
                case "Invoker":
                    num = 40;
                    break;
                case "Io":
                    num = 41;
                    break;
                case "Jakiro":
                    num = 42;
                    break;
                case "Juggernaut":
                    num = 43;
                    break;
                case "Keeper of the Light":
                    num = 44;
                    break;
                case "Kunkka":
                    num = 45;
                    break;
                case "Legion Commander":
                    num = 46;
                    break;
                case "Leshrac":
                    num = 47;
                    break;
                case "Lich":
                    num = 48;
                    break;
                case "Lifestealer":
                    num = 49;
                    break;
                case "Lina":
                    num = 50;
                    break;
                case "Lion":
                    num = 51;
                    break;
                case "LoneDruid":
                    num = 52;
                    break;
                case "Luna":
                    num = 53;
                    break;
                case "Lycan":
                    num = 54;
                    break;
                case "Magnus":
                    num = 55;
                    break;
                case "Marci":
                    num = 56;
                    break;
                case "Mars":
                    num = 57;
                    break;
                case "Medusa":
                    num = 58;
                    break;
                case "Meepo":
                    num = 59;
                    break;
                case "Mirana":
                    num = 60;
                    break;
                case "Monkey King":
                    num = 61;
                    break;
                case "Morphling":
                    num = 62;
                    break;
                case "Naga Siren":
                    num = 63;
                    break;
                case "Nature`s Prophet":
                    num = 64;
                    break;
                case "Necrophos":
                    num = 65;
                    break;
                case "Night Stalker":
                    num = 66;
                    break;
                case "Nyx Assassin":
                    num = 67;
                    break;
                case "Ogre Magi":
                    num = 68;
                    break;
                case "Omniknight":
                    num = 69;
                    break;
                case "Oracle":
                    num = 70;
                    break;
                case "Outworld Devourer":
                    num = 71;
                    break;
                case "Pangolier":
                    num = 72;
                    break;
                case "Phantom Assassin":
                    num = 73;
                    break;
                case "Phantom Lancer":
                    num = 74;
                    break;
                case "Phoenix":
                    num = 75;
                    break;
                case "Primal Beast":
                    num = 76;
                    break;
                case "Puck":
                    num = 77;
                    break;
                case "Pudge":
                    num = 78;
                    break;
                case "Pugna":
                    num = 79;
                    break;
                case "Queen of Pain":
                    num = 80;
                    break;
                case "Razzor":
                    num = 81;
                    break;
                case "Riki":
                    num = 82;
                    break;
                case "Rubick":
                    num = 83;
                    break;
                case "SandKing":
                    num = 84;
                    break;
                case "Shadow Demon":
                    num = 85;
                    break;
                case "Shadow Fiend":
                    num = 86;
                    break;
                case "Shadow Shaman":
                    num = 87;
                    break;
                case "Silencer":
                    num = 88;
                    break;
                case "Skywrath Mage":
                    num = 89;
                    break;
                case "Slardar":
                    num = 90;
                    break;
                case "Slark":
                    num = 91;
                    break;
                case "Snapfire":
                    num = 92;
                    break;
                case "Sniper":
                    num = 93;
                    break;
                case "Spectre":
                    num = 94;
                    break;
                case "SpiritBreaker":
                    num = 95;
                    break;
                case "Storm Spirit":
                    num = 96;
                    break;
                case "Sven":
                    num = 97;
                    break;
                case "Techies":
                    num = 98;
                    break;
                case "Templar Assassin":
                    num = 99;
                    break;
                case "Terrorblade":
                    num = 100;
                    break;
                case "Tidehunter":
                    num = 101;
                    break;
                case "Timbersaw":
                    num = 102;
                    break;
                case "Tinker":
                    num = 103;
                    break;
                case "Tiny":
                    num = 104;
                    break;
                case "TreantProtector":
                    num = 105;
                    break;
                case "TrollWarlord":
                    num = 106;
                    break;
                case "Tusk":
                    num = 107;
                    break;
                case "Underlord":
                    num = 108;
                    break;
                case "Undying":
                    num = 109;
                    break;
                case "Ursa":
                    num = 110;
                    break;
                case "VengefulSpirit":
                    num = 111;
                    break;
                case "Venomancer":
                    num = 112;
                    break;
                case "Viper":
                    num = 113;
                    break;
                case "Visage":
                    num = 114;
                    break;
                case "Void Spirit":
                    num = 115;
                    break;
                case "Warlock":
                    num = 116;
                    break;
                case "Weaver":
                    num = 117;
                    break;
                case "Windranger":
                    num = 118;
                    break;
                case "Winter Wyvern":
                    num = 119;
                    break;
                case "Witch Doctor":
                    num = 120;
                    break;
                case "Wraith King":
                    num = 121;
                    break;
                case "Zeus":
                    num = 122;
                    break;
            }

            int y = num / 5;
            int x = num % 5;

            Image source_img = Image.FromFile("resources\\heroes.png");
            Image bitmap = new Bitmap(112, 64, source_img.PixelFormat);
            Graphics graphics = Graphics.FromImage(bitmap);


            Rectangle source_rect = new Rectangle(0, 0, 112, 64);
            graphics.DrawImage(source_img, source_rect, x * 121, y * 71, 112, 64, GraphicsUnit.Pixel);
            img = bitmap;
        }
    }
}
