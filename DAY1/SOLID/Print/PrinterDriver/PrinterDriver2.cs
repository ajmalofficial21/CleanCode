public class PrinterDriver2
{
    private IInputDevice inputDevice;
    private Printer printer;

    public PrinterDriver2(IInputDevice inputDevice, Printer printer)
    {
        this.inputDevice = inputDevice;
        this.printer = printer;
    }

    public void Print()
    {
        while (!inputDevice.IsEndOfDocument())
        {
            printer.Print(inputDevice.ReadPage());
        }
    }
}