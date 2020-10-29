using CS1_Projekt_OOP2.Classes;
using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS1_Projekt_OOP2
{
    /*
     
    Welcome to the Warehouse Control Panel!
    This program simulates the creation and management of some commercial organizations customers, products and orders.

    Already added is some sample data for testing different outcomes of the batch-processing method of orders (Press "Process Orders")
    found in the Warehouse class. Where orders are displayed in a datagridview they can be clicked to open the
    ViewOrder form which shows additional information.

    Orders may be imported by placing a .json file in the bin/Debug/neworders folder.
    The Warehouse class handles this import under the region "Utility methods".
    An example JSON file can be found in the folder "Example JSON" in the project folder.
    
    Thanks for a fun project!

    Moa & Nazgul & Victor & Jens

     */


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IWarehouse wh = new Warehouse();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRMMain(wh));
        }
    }
}
