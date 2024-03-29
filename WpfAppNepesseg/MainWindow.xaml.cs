﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using WpfAppNepesseg.Model;

namespace WpfAppNepesseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Telepules> telepulesek = new List<Telepules>();

        public MainWindow()
        {
            InitializeComponent(); 

            //todo Hajtsa végre az alábbi lépéseket!
            //Adatok beolvasása fájlból

            //Minden egyes sor esetén (kivéve az elsőt) alkalmazza a Split-et!

            //Az adattagokat felhasználva hozzon létre egy Tepeulés osztályú objektumot, amit helyezzen a telepulesek listába!
            //Amennyiben szükséges zárja le az állományt!

            //Az adatokból kiszedjük a lehetséges megyék kódjait
            
            Dictionary<string, int> megyek = new Dictionary<string, int>();
            foreach (var item in telepulesek)
            {
                if (!megyek.ContainsKey(item.Megye))
                {
                    megyek.Add(item.Megye, 1);
                }
            }

            foreach (var item in megyek.Keys)
            {
                cbMegyek.Items.Add(item);
            }
            
            //LINQ segítségével egyszerűbb lenne!
            //cbMegyek.ItemsSource =telepulesek.Select(obj => obj.Megye).Distinct().ToList();

            dgTelepulesek.ItemsSource = telepulesek;
            labSorokSzama.Content = telepulesek.Count;
        }


        private void cbMegyek_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //todo kezelje az eseményt!
        }
    }
}
