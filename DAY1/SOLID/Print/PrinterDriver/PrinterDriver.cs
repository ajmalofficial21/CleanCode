using System;

public class PrinterDriver
{
    private File file;
    private Printer printer;
    private Scanner scanner;
    private Fax fax;

    public PrinterDriver(File file, Printer printer)
    {
        this.file = file;
        this.printer = printer;
        this.scanner = null;
        this.fax = null;
    }

    public PrinterDriver(Scanner scanner, Printer printer)
    {
        this.file = null;
        this.printer = printer;
        this.scanner = scanner;
        this.fax = null;
    }

    public PrinterDriver(Fax fax, Printer printer)
    {
        this.file = null;
        this.printer = printer;
        this.scanner = null;
        this.fax = fax;
    }

    public void Print()
    {
        if (file != null)
        {
            Buffer page = this.file.ReadPage();
            while (!this.file.IsEndOfFile(page))
            {
                printer.Print(page);
                page = this.file.ReadPage();
            }
        }
        else if (scanner != null)
        {
            while (!scanner.IsEndOfDocument())
            {
                printer.Print(scanner.ReadPage());
            }
        }
        else
        {
            while (!fax.IsEndOfDocument())
            {
                printer.Print(fax.ReadPage());
            }
        }
    }
}