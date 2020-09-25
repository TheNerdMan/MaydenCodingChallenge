using Mayden_Coding_Challenge.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Mayden_Coding_Challenge.Services
{
    public class ShoppingListController
    {
        List<ShoppingListItem> shoppingList = new List<ShoppingListItem>();

        /// <summary>
        /// Gets shopping list from JSON file
        /// </summary>
        /// <returns>full shopping list</returns>
        public List<ShoppingListItem> getShoppingList()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
            var fileContents = File.ReadAllText(filePath);
            shoppingList = JsonConvert.DeserializeObject<List<ShoppingListItem>>(fileContents);

            return shoppingList;
        }

        /// <summary>
        /// Puts the list into the persistant storage
        /// </summary>
        /// <returns>true or false if successful</returns>
        private bool putShoppingList()
        {
            try
            {
                var serialized = JsonConvert.SerializeObject(shoppingList);

                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
                File.WriteAllText(filePath, serialized);
            } catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds a new item to the list
        /// </summary>
        /// <param name="newItem">new Item</param>
        /// <returns>updated list</returns>
        public List<ShoppingListItem> addItem(ShoppingListItem newItem)
        {
            try
            {
                shoppingList.Add(newItem);
                putShoppingList();
            }
            catch (Exception ex)
            {
                // TODO: Handel error
            }

            return shoppingList;
        }

        /// <summary>
        /// Removes an item from the list
        /// </summary>
        /// <param name="index">items index</param>
        /// <returns>updated list</returns>
        public List<ShoppingListItem> removeItem(int index)
        {
            try
            {
                shoppingList.RemoveAt(index);
                putShoppingList();
            }
            catch (Exception ex)
            {
                // TODO: Handel error
            }

            return shoppingList;
        }

        /// <summary>
        /// Updates an item based on index
        /// </summary>
        /// <param name="index">items index</param>
        /// <param name="updatedItem">updated item</param>
        /// <returns>updated list</returns>
        public List<ShoppingListItem> updateItem(int index, ShoppingListItem updatedItem)
        {
            try
            {
                shoppingList.RemoveAt(index);
                shoppingList.Add(updatedItem);
                putShoppingList();
            }
            catch (Exception ex)
            {
                // TODO: Handel error
            }

            return shoppingList;
        }
    }
}