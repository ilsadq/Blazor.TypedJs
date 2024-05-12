# Blazor.TypedJs

[TypedJs Website](https://mattboldt.com/demos/typed-js/)

Typed.js is a library that types. Enter in any string, and watch it type at the speed you've set, backspace what it's typed, and begin a new sentence for however many strings you've set.

### Install

App.razor

```<script src="_content/Blazor.TypedJs/typed.umd.js"></script>```

Program.cs

```builder.Services.AddScoped<TypedJsProvider>();```


### Examples

```
<TypedWrapper TypeSpeed="100" Strings="@(["Hello World", "World Hello"])" />
<TypedWrapper TypeSpeed="100" Strings="@(["<h1>Hello World</h1>", "<p>World Hello</p>"])" />
```

TypedJsProvider.cs

```cs
await TypedJs.Init(Id, Strings, TypeSpeed);

await TypedJs.Remove(Id);
```
