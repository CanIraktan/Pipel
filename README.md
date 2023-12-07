# Pipel

MIT License

[Download from NuGet](https://www.nuget.org/packages/Pipel).

## Overview

Simple named pipe bidirectional object transfer engine for .NET

Library that allows communication between applications on the same computer with named pipe structure. It supports sending objects with json boxing and unboxing.

## Usage

To use Pipel, simply run a static method with the name parameter:

```csharp
PipelEngine.Start("pipe_name");
```

In order to process incoming messages, you need to connect the event to the appropriate method:
```csharp
PipelEngine.Receive += PipelMessageReceived;
```

Receive Method Sample (PipeCommand is a custom object used in the sample application)
```csharp
private void PipeMessageReceived(PipelMessage message)
{
    try
    {
        if(this.InvokeRequired)
        {
            this.Invoke(new MessageDelegate(PipeMessageReceived), message);
        }
        else
        {
            PipeCommand cm = PipeCommand.GetCommand(message);

            if(cm.Type == PipeMessageTypes.TakePhoto)
                txtMessages.AppendText(DateTime.Now.ToLongTimeString() + ":(Object) " + cm.ConvertLoad<List<int>>() + Environment.NewLine);
            else if(cm.Type == PipeMessageTypes.ShowMessage)
                txtMessages.AppendText(DateTime.Now.ToLongTimeString() + ":(Text) " + cm.Load + Environment.NewLine);
        }
    }
    catch(Exception ex)
    {
        txtMessages.AppendText(ex.Message + Environment.NewLine);
    }
}
```

To stop:
```csharp
PipelEngine.Stop();
```

Send message examples:
```csharp
PipelEngine.Send("Test Message", "other_app");

PipelEngine.Send(new List<int> { 125, 138, 245 }, "other_app");
```

## Features

PipeRpc supports the following features:

* Newtonsoft.Json library is used for serialisation;
* Information on which name the incoming messages come from;
* General boxing and unboxing methods;
* Simple operation and structure


## Performance

Performance tests have not yet been carried out
```
              Method |      Mean |      Error |     StdDev |
-------------------- |----------:|-----------:|-----------:|
 ReturnComplexObject |      - us |       - us |       - us |
        Cancellation |      - us |       - us |       - us |
           ReturnInt |      - us |       - us |       - us |
```

## License
Copyright (c) 2023 Can Iraktan. All rights reserved  
This repository is licensed under  MIT License - see [`License`](LICENSE) for more details.
