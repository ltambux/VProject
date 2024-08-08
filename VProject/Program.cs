using System;
using System.Windows.Forms;
using VProject.Services;
using VProject.Ui;

namespace VProject;

static class Program{
    /// <summary> The main entry point for the application. </summary>
    [STAThread]
    static void Main(){
        try{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Log.Configure("VProject.txt");
            Application.Run(new Mainframe());
        }catch(Exception ex){
            Log.Error(ex.ToString());
        }
    }
}