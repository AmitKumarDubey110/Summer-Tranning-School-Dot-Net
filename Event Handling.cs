using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Event_Handling_
{
    using System.Collections;

    public class ListWithChangedEvent : ArrayList
    {
        public event EventHandler Changed;

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this.e);
        }

        public override int Add(object value)
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }

        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    } 
  }

namespace TestEvents
{
    using System.Collections;

    class EventListner
    {
        private ListWithChangedEvent List;

        public EventListner(ListWithChangedEvent list)
        {
            List = list;
            List.Changed += new EventHandler(ListChanged);
        }

        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            List.Changed -= new EventHandler(ListChanged);
            List = null;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                ListWithChangedEvent list = new ListWithChangedEvent();

                EventListner listner = new EventListner(list);

                list.Add("item 1");
                list.Clear();
                listener.Detach();
            }
        }
    }
