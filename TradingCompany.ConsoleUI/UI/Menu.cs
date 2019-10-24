﻿using System;
using System.Collections.Generic;
using TradingCompany.ConsoleUI.Abstractions.RepoMenu;
using TradingCompany.ConsoleUI.RepoMenu.Implementations;
using TradingCompany.DAL.Models.Entities.Abstractions;
using TradingCompany.DAL.Models.Filters.Abstractions;
using TradingCompany.DAL.Repository.Abstractions;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.Models.Entities.Implementations;

namespace TradingCompany.ConsoleUI.UI
{
    public class Menu
    {
        private List<string> MainMenuValues;
        private List<string> TablesMenuValues;
        private List<string> ActionsMenuValues;

        private UserMenu userMenu;
        private SupplierToProductMenu suppToProdtMenu;
        private RoleMenu roleMenu;
        private ProductMenu product;
        private OrderToProductMenu orderToProduct;
        private OrderMenu order;
        private SupplierMenu supplierMenu;

        public Menu()
        {
            Initialize();
            //List<IRepository<IBaseEntity, IFilterable> repositories = new List<DAL.Repository.Abstractions.IRepository>();
        }

        public void Initialize()
        {
            userMenu = new UserMenu();
            suppToProdtMenu = new SupplierToProductMenu();
            
            roleMenu = new RoleMenu();
            product = new ProductMenu();
            supplierMenu = new SupplierMenu();

            this.ActionsMenuValues = new List<string>(){ "1. Create", "2. Delete", "3. Update", "4. Show", "5. Exit" };
            this.TablesMenuValues = new List<string>() { "1. User", "2. Supplier", "3. SuppliersToProducts", "4. Roles", "5. Product", "6. OrderToProduct", "7. Order", "2. Exit" };
            this.MainMenuValues = new List<string>() { "1. Tables", "2. Exit" };
        }
        public void MainMenu()
        {
            ConsoleKey action;
            do
            {
                Console.Clear();
                PrintMainMenu();
                action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        TablesMenu();
                        break;
                    case ConsoleKey.D2:
                        action = ConsoleKey.Escape;
                        break;
                }
            } while (action != ConsoleKey.Escape);
        }
        private void TablesMenu()
        {
            int chosenTable = 0;
            ConsoleKey action;
            PrintMainMenu();
            do
            {
                Console.Clear();
                PrintTablesMenu();
                action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        chosenTable = 1;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D2:
                        chosenTable = 0;
                        action = ConsoleKey.Escape;
                        break;
                }
            } while (action != ConsoleKey.Escape);
        }
        private void ActionsMenu(int chosenTable)
        {
            ConsoleKey action;
            PrintActions();
            do
            {
                Console.Clear();
                PrintActions();
                action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        AddEntity(chosenTable);
                        break;
                    case ConsoleKey.D2:
                        DeleteEntity(chosenTable);
                        break;
                    case ConsoleKey.D3:
                        Update(chosenTable);
                        break;
                    case ConsoleKey.D4:
                        PrintTable(chosenTable);
                        break;
                    case ConsoleKey.D5:
                        action = ConsoleKey.Escape;
                        break;
                }
            } while (action != ConsoleKey.Escape);
        }
        private void PrintMainMenu() {
            foreach(string el in MainMenuValues)
            {
                Console.WriteLine(el);
            }
        }
        private void PrintTablesMenu()
        {
            foreach (string el in TablesMenuValues)
            {
                Console.WriteLine(el);
            }
        }
        private void PrintActions()
        {
            foreach (string el in ActionsMenuValues)
            {
                Console.WriteLine(el);
            }
        }
        private void PrintTable(int chosenTable)
        {
            this.TablesMenuValues = new List<string>() { "1. User", "2. Supplier", "3. SuppliersToProducts", "4. Roles", "5. Product", "6. OrderToProduct", "7. Order", "2. Exit" };

            switch (chosenTable)
            {
                case 1:
                    userMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.Read();
                    break;
                case 2:
                    supplierMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.Read();
                    break;
                case 3:
                    userMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.Read();
                    break;
                case 4:
                    userMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.Read();
                    break;
                case 5:
                    userMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.Read();
                    break;
                case 6:
                    userMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.Read();
                    break;
                case 7:
                    userMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.Read();
                    break;
            }
        }

        private void AddEntity(int chosenTable)
        {
            switch (chosenTable)
            {
                case 1:
                    userMenu.Add();
                    break;
            }
        }
        private void DeleteEntity(int chosenTable)
        {
            Console.Write("Id: ");
            ulong id = Convert.ToUInt64(Console.ReadLine());
            switch (chosenTable)
            {
                case 1:
                    userMenu.Delete(id);
                    break;
            }
        }
        private void Update(int chosenTable)
        {
            Console.Write("Id: ");
            ulong id = Convert.ToUInt64(Console.ReadLine());
            switch (chosenTable)
            {
                case 1:
                    userMenu.Delete(id);
                    break;
              
            }
        }
    }
}