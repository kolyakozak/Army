using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    static class Cui
    {
        public static void Show()
        {
            while (true) {
                Console.WriteLine("1. Get all men");
                Console.WriteLine("2. Get all militaries");
                Console.WriteLine("0. Exit");
                int key = 0;
                try { key = Convert.ToInt32(Console.ReadLine()); }
                catch(Exception e) { Console.Clear(); Console.WriteLine("The input must be a number between 0 and 2"); continue; }
                switch (key)
                {
                    case 1: { Console.Clear(); AllMenMenu(); } break;
                    case 2: { Console.Clear(); AllMilitariesMenu(); } break;
                    case 0: return;
                    default: 
                        {
                            Console.Clear();
                            Console.WriteLine("Not correct code");
                        } 
                        break;
                }
            }
        }
        private static void AllMenMenu()
        {
            while (true)
            {
                DataBase.ukraine.Display(2);
                Console.WriteLine("1. Add man");
                Console.WriteLine("2. Remove man");
                Console.WriteLine("3. Send a man to the army");
                Console.WriteLine("4. Init conscription");
                Console.WriteLine("0. Go Back");
                int key = 0;
                try { key = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number between 0 and 3"); continue; }
                switch (key)
                {
                    case 1: { Console.Clear(); CreateManMenu(); } break;
                    case 2: { Console.Clear(); RemoveManMenu(); } break;
                    case 3: { Console.Clear(); GoToArmyMenu(); } break;
                    case 4: { Console.Clear(); DataBase.ukraine.Conscription(); Console.WriteLine("Conscription completed"); } break;
                    case 0: { Console.Clear(); return; };
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Not correct code");
                        }
                        break;
                }
            }
        }
        private static void AllMilitariesMenu()
        {
            while (true)
            {
                DataBase.militaryBase.Display();
                Console.WriteLine("1. Get military info");
                Console.WriteLine("0. Go Back");
                int key = 0;
                try { key = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number between 0 and 1"); continue; }
                switch (key)
                {
                    case 1: { Console.Clear(); GetMilitaryMenu(); } break;
                    case 0: { Console.Clear(); return; };
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Not correct code");
                        }
                        break;
                }
            }
        }
        private static void CreateManMenu()
        {
            string fullname;
            string address;
            while (true)
            {
                Console.WriteLine("Enter fullname:");
                fullname = Console.ReadLine();
                if (fullname.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Fullname can't be empty");
                    continue;
                }
                else break;
            }
            while (true)
            {
                Console.WriteLine("Enter the address with spaces (For example: Kyiv Brovary):");
                address = Console.ReadLine();
                if (address.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Address can't be empty");
                    continue;
                }
                else break;
            }
            DataBase.ukraine.AddMan(new ManProxy(fullname), new List<string>(address.Split(' ')));
            Console.Clear();
            Console.WriteLine($"Man {fullname} succesfully added");
        }
        private static void RemoveManMenu()
        {
            int id;
            while(true)
            {
                Console.WriteLine("Enter man id:");
                try { id = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The id must be a number"); continue; }
                if (id < 0)
                {
                    Console.Clear();
                    Console.WriteLine("The id must be a positive number");
                }
                else break;
            }
            Console.Clear();
            if (DataBase.ukraine.RemoveMan(id)) Console.WriteLine($"Man with id {id} succesfuly removed");
            else Console.WriteLine($"There is no man with id {id}");
        }
        private static void GoToArmyMenu()
        {
            int id;
            Builder builder;
            while (true)
            {
                Console.WriteLine("Enter man id:");
                try { id = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The id must be a number"); continue; }
                if (id < 0)
                {
                    Console.Clear();
                    Console.WriteLine("The id must be a positive number");
                }
                else break;
            }
            while(true)
            {
                Console.WriteLine("Choose type of troop:");
                Console.WriteLine("0. Marine");
                Console.WriteLine("1. Pilot");
                Console.WriteLine("2. TankMan");
                Console.WriteLine("3. Sniper");
                int key;
                try { key = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number between 0 and 3"); continue; }
                switch(key)
                {
                    case 0: builder = DataBase.marineBuilder; break;
                    case 1: builder = DataBase.pilotBuilder; break;
                    case 2: builder = DataBase.tankManBuilder; break;
                    case 3: builder = DataBase.sniperBuilder; break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("The input must be a number between 0 and 3");
                            continue;
                        }
                }
                break;
            }
            Man man = DataBase.ukraine.GetMan(id);
            Console.Clear();
            if (man != null) 
            {
                man.GoToArmy(builder);
                Console.WriteLine($"Man with id {id} joined the army"); 
            }
            else Console.WriteLine($"There is no man with id {id}");
        }
        private static void GetMilitaryMenu()
        {
            int id;
            while (true)
            {
                Console.WriteLine("Enter military id:");
                try { id = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The id must be a number"); continue; }
                if (id < 0)
                {
                    Console.Clear();
                    Console.WriteLine("The id must be a positive number");
                }
                else break;
            }
            Military mil = DataBase.militaryBase.GetMilitary(id);
            if (mil != null)
            {
                Console.Clear();
                MilitaryInfoMenu(mil);
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"There is no military with id {id}");
            }
        }
        private static void MilitaryInfoMenu(Military mil)
        {
            while(true)
            {
                mil.Display();
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Change rank");
                Console.WriteLine("2. Order");
                Console.WriteLine("3. Change Weapon");
                Console.WriteLine("4. Set Silencer on weapon");
                Console.WriteLine("5. Set Sight on weapon");
                Console.WriteLine("0. Go Back");
                int key;
                try { key = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number between 0 and 3"); continue; }
                switch (key)
                {
                    case 1: { Console.Clear(); ChangeRankMenu(mil); } break;
                    case 2: { Console.Clear(); OrderMenu(mil); } break;
                    case 3: { Console.Clear(); ChangeWeaponMenu(mil); } break;
                    case 4: { Console.Clear(); mil.weapon = new SilencerDecorator(mil.weapon); } break;
                    case 5: { Console.Clear(); mil.weapon = new SightDecorator(mil.weapon); } break;
                    case 0: { Console.Clear(); return; };
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("The input must be a number between 0 and 3");
                            continue;
                        } 
                }
            }
        }
        private static void ChangeRankMenu(Military mil)
        {
            while(true)
            {
                Console.WriteLine("Select new rank:");
                Console.WriteLine("0. Private");
                Console.WriteLine("1. Sergeant");
                Console.WriteLine("2. Major");
                Console.WriteLine("3. Colonel");
                int key;
                try { key = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number between 0 and 3"); continue; }
                switch(key)
                {
                    case 0: mil.ChangeRank(new Private(mil.Fullname)); break;
                    case 1: mil.ChangeRank(new Sergeant(mil.Fullname)); break;
                    case 2: mil.ChangeRank(new Major(mil.Fullname)); break;
                    case 3: mil.ChangeRank(new Colonel(mil.Fullname)); break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("The input must be a number between 0 and 3");
                            continue;
                        }
                }
                Console.Clear();
                break;
            }
        }
        private static void OrderMenu(Military mil)
        {
            string order;
            while (true)
            {
                Console.WriteLine("Enter an order:");
                order = Console.ReadLine();
                if(order.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("The order can't be an empty string");
                    continue;
                }
                break;
            }
            Console.Clear();
            mil.ExecuteOrder(order);
        }
        private static void ChangeWeaponMenu(Military mil)
        {
            string title;
            int ammo;
            int acc;
            int nois;
            while (true)
            {
                Console.WriteLine("Enter weapon Title:");
                title = Console.ReadLine();
                if(title.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Weapon title can't be an empty string");
                    continue;
                }
                break;
            }
            while(true)
            {
                Console.WriteLine("Enter maximum weapon Ammunition:");
                try { ammo = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number"); continue; }
                if(ammo <= 0) { Console.Clear(); Console.WriteLine("The input must be a positive number"); continue; }
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter weapon Accuracy:");
                try { acc = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number"); continue; }
                if (acc <= 0) { Console.Clear(); Console.WriteLine("The input must be a positive number"); continue; }
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter weapon Noisiness:");
                try { nois = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e) { Console.Clear(); Console.WriteLine("The input must be a number"); continue; }
                if (nois <= 0) { Console.Clear(); Console.WriteLine("The input must be a positive number"); continue; }
                break;
            }
            mil.weapon = new RealWeapon(title, ammo, acc, nois);
        }
    }
}
