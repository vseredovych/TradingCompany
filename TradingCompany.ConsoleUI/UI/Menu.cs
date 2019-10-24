using System;
using System.Collections.Generic;
using TradingCompany.ConsoleUI.Implementations.RepoMenu;
using TradingCompany.DAL.Models.Entities.Abstractions;
using TradingCompany.DAL.Models.Filters.Abstractions;
using TradingCompany.DAL.Repository.Abstractions;


namespace TradingCompany.ConsoleUI.UI
{
    public class Menu
    {
        private List<string> MainMenuValues;
        private List<string> TablesMenuValues;
        private List<string> ActionsMenuValues;
        private UserMenu userMenu;
        public Menu()
        {
            Initialize();
            MainMenu();
            //List<IRepository<IBaseEntity, IFilterable> repositories = new List<DAL.Repository.Abstractions.IRepository>();
        }

        public void Initialize()
        {
            userMenu = new UserMenu();
            this.MainMenuValues = new List<string>(){ "Tables", "Exit" };
            this.MainMenuValues = new List<string>() { "Table", "Exit" };
            this.MainMenuValues = new List<string>() { "Tables", "Exit" };
        }
        private void MainMenu()
        {
            ConsoleKey action;
            int choose_key = 1;
            //print
            do
            {
                Console.Clear();
                PrintMainMenu();
                action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.UpArrow:
                        choose_key -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        choose_key += 1;
                        break;
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                }
            } while (action != ConsoleKey.Escape);
        }
        private void PrintMainMenu() {

        }
    }
}