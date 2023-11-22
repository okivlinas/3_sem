using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class List
    {
        private int[] elements;
        private Production production;

        public class Production
        {
            public int Id { get; set; }
            public string OrganizationName { get; set; }

            public Production(int id, string organizationName)
            {
                Id = id;
                OrganizationName = organizationName;
            }
            public class Developer
            {
                public string FullName { get; set; }
                public int Id { get; set; }
                public string Department { get; set; }

                public Developer(string fullname, int id, string department)
                {
                    FullName = fullname;
                    Id = id;
                    Department = department;
                }

            }
        }
        public List()
        {
            elements = new int[0];
        }
        public List(int[] values)
        {
            elements = new int[values.Length];
            Array.Copy(values, elements, values.Length);
        }
        public int this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }
        public static List operator +(List list1, List list2)
        {
            int[] combinedElements = new int[list1.elements.Length + list2.elements.Length];
            list1.elements.CopyTo(combinedElements, 0);
            list2.elements.CopyTo(combinedElements, list1.elements.Length);
            return new List(combinedElements);
        }
        public static List operator --(List list)
        {
            int[] newElement = new int[list.elements.Length - 1];
            Array.Copy(list.elements, 1, newElement, 0, list.elements.Length - 1);
            return new List(newElement);
        }
        public static bool operator ==(List list1, List list2)
        {
            if(list1.elements.Length != list2.elements.Length)
                return false;
            
            for(int i = 0; i < list1.elements.Length; i++)
            {
                if (list1.elements[i]!=list2.elements[i])
                    return false;
            }

            return true;
        }
        public static bool operator !=(List list1, List list2)
        {
            return !(list1 == list2);
        }

        public static bool operator true(List list)
        {
            return list.elements.Length == 0;
        }
        public static bool operator false(List list)
        {
            return list.elements.Length != 0;
        }
    }
}
