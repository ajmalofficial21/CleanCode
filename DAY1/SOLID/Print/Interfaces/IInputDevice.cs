using System;

public interface IInputDevice
{
    bool IsEndOfDocument();

    Buffer ReadPage();
}