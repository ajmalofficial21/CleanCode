using System;

public class Fax : IInputDevice
{
    public bool IsEndOfDocument()
    {
        throw new NotImplementedException();
    }
    public Buffer ReadPage()
    {
        throw new NotImplementedException();
    }
}