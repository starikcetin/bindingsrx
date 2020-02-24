[![openupm](https://img.shields.io/npm/v/com.grofit.bindingsrx?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.grofit.bindingsrx/)

This repository has UPM support. Install it with:

```
npm install -g openupm-cli
openupm add com.grofit.bindingsrx
```

----

# BindingsRx

BindingsRx is a one or two way binding system for unity using unirx.

[![Discord](https://img.shields.io/discord/488609938399297536.svg)](https://discord.gg/bS2rnGz)

It allows you to write more succinct code while showing intent for properties which are bound to other properties, and looks something like this:

```c#
myInputField.BindTextTo(someReactiveProperty);
// Changing myInputField.text will update someReactiveProperty and vice versa
```

## Dependencies

- [UniRx](https://github.com/neuecc/UniRx) 

## Features

- Supports one and two way binding
- Helpers for creating your own custom bindings
- Works with `ReactiveProperty<T>` and regular values
- Supports custom processing on binding via `IFilter` interface
- Simplifies complex UI interactions, such as binding dropdown options

As mentioned it works with the unirx `ReactiveProperty<T>` but does not need them, so for example if I had a reactive property I could do:

```c#
var myReactiveProperty = new ReactiveProperty<float>(1.0f);
mySlider.BindValueTo(myReactiveProperty);
```

However if I was working with a 3rd party library I may not have ReactiveProperty objects, so for that I would do:

```c#
var myNormalValue = 1.0f;
mySlider.BindValueTo(() => myNormalValue, x => myNormalValue = x);
```

You can also specify if you want one way or two way bindings explicitly.

```c#
var myReactiveProperty = new ReactiveProperty<float>(1.0f);
mySlider.BindValueTo(myReactiveProperty, BindingTypes.OneWay);
```

Here is an example of making a dropdown in the UI bind to a reactive collection:

```c#
var exampleOptions = new ReactiveCollection<string>();
exampleOptions.Add("Option 1");
exampleOptions.Add("Option 2");
exampleOptions.Add("Some Other Option");

someDropdownUIElement.BindOptionsTo(exampleOptions);
```


## Installation

You can take the unitypackage installation file from the relevent release.

## Quick Start

- Install the above package
- Install UniRx 

## Running Examples

If you want to run the examples then just clone it and open the unity project in the `src` folder, then run the examples, I will try to add to as the library matures.

There are also a suite of tests which are being expanded as the project grows.

## Docs

See the docs folder for more information. (This will grow)

## Other Blurbs

If you like design patterns and practices then there is also a ECS framework built on unirx which can be found @ [grofit/ecsrx](https://github.com/grofit/ecsrx).
