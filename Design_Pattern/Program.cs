// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using Design_Pattern;

//IComponent<T> icomponent1 = new IComponent<T>();
IComponent<string> icomponent = new ConcreteComponent();
Console.WriteLine(icomponent.GetText());

IComponent<string> plainDecorator = new PlainDecorator(icomponent, "Hello, Pooja! How are you doing today? ");
Console.WriteLine(plainDecorator.GetText());

IComponent<string> colorDecorator = new ColorDecorator(icomponent);
Console.WriteLine(colorDecorator.GetText());

IComponent<string> upperCaseDecorator = new UpperCaseDecorator(icomponent);
Console.WriteLine(upperCaseDecorator.GetText());



IComponent<string> lowerCaseDecorator = new LowerCaseDecorator(icomponent);
Console.WriteLine(lowerCaseDecorator.GetText());

IComponent<string> backgroundColorDecorator = new BackgroundColorDecorator(icomponent);
Console.WriteLine(backgroundColorDecorator.GetText());





