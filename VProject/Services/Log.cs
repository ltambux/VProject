using System;
using System.IO;
using System.Windows.Forms;

namespace VProject.Services;
public static class Log{
    private static string DEFAULT_PATH=Path.Combine(Path.GetTempPath(),"Logs");
    private static string time=>$"{DateTime.Now:yyyy-MM-dd_hh}";
    private static StreamWriter _w;
    private static string _dir;
    private static string _file;
    public static string Directory=>_dir;
    public static string FileName=>_file;
    public static string FullPath=>Path.Combine(_dir,_file);

    public static void Configure(string name=null,string directoryPath=null){
        _file=name ?? $"Log_{time}.txt";
        _dir=directoryPath ?? DEFAULT_PATH;
        System.IO.Directory.CreateDirectory(_dir);
        _w=new(Path.Combine(_dir,_file),true);
        _w.AutoFlush=true;
        _write("Configured",[$"at {_dir}"]);
    }

    public static void Debug(params string[] msg)=>_write("DEBUG",msg);
    public static void Error(params string[] msg)=>_write("ERROR",msg);
    public static void Info(params string[] msg)=>_write("INFO",msg);
    public static void Warn(params string[] msg)=>_write("WARN",msg);

    private static void _show(string type,string[] msg)=>MessageBox.Show(string.Join("\n\t",msg),
        $"[{time}] {type}",MessageBoxButtons.OK);

    private static void _write(string type,string[] msg)=>_w.Write($"[{time}] {type}:\n\t{string.Join("\n\t",msg)}\n");
}