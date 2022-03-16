using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    class TableRequests : IEnumerable<string>
    {
        public Dictionary<string, List<IMenuItem>> table { get; } = new Dictionary<string, List<IMenuItem>>();
        public List<IMenuItem> this[string name]
        {
            get
            {
                return table[name];
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in table.Keys)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public List<T> Get<T>() where T : IMenuItem
        {
            List<T> orders = new List<T>();
            foreach (var item in table.Values)
            {
                foreach (var menuItem in item)
                {
                    if (menuItem is T)
                        orders.Add((T)menuItem);
                }
            }
            return orders;
        }
        public void Add<T>(string name) where T : IMenuItem
        {
            if (table.ContainsKey(name))
                table[name].Add(Activator.CreateInstance<T>());
            else
            {
                List<IMenuItem> that = new List<IMenuItem>();
                that.Add(Activator.CreateInstance<T>());
                table.Add(name, that);
            }
        }
    }
}
