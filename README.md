# CarbonCUIExtensions

## Overview

`CarbonCUIExtensions` is a project that provides a set of extension methods and overloads for working with Carbon's UI components. These extensions are designed to enhance and simplify the development of user interfaces within the Rust server environment, leveraging the power of Carbon and Unity's UI system.

## Features

- **Transform Management**: Simplified methods for handling UI transformations.
- **Extended UI Creation**: Additional methods for creating panels, text, buttons, and images with enhanced configurations.
- **Utility Functions**: Helpful utilities for parsing and managing UI-related data.
- **Dynamic Interfaces**: The ability to create interfaces based on lists and classes with convenient data storage options for transforms, enabling much easier creation of dynamically changeable interfaces.

## Installation

To include `CarbonCUIExtensions` in your project, follow these steps:

1. **Include the project in your Rust server:**
   - Copy the contents of the `build` folder into your `carbon` directory.

2. **Add necessary references in your C# scripts:**
    ```csharp
    using Carbon.Components;
    using static Carbon.Components.CUI;
    using UnityEngine;
    using UnityEngine.UI;
    using Oxide.Game.Rust.Cui;
    ```

## Usage

Here are some examples of how to use the extension methods provided by `CarbonCUIExtensions` in Carbon plugins.

### Example 1: Creating a Panel

```csharp
namespace Carbon.Plugins
{
    [Info("ExamplePlugin", "AuthorName", "1.0.0")]
    [Description("An example plugin using CarbonCUIExtensions")]
    public class ExamplePlugin : CarbonPlugin
    {
        private void OnServerInitialized()
        {
            Puts("Hello world!");

            CUITransform transform = new CUITransform
            {
                xMin = 0.1f,
                xMax = 0.9f,
                yMin = 0.1f,
                yMax = 0.9f
            };

            using var cui = new CUI(CuiHandler);
            var container = cui.CreateContainer("ExampleContainer", color: "0.5 0.5 0.5 0.8");

            var panel = cui.CreatePanel(container, "ExampleContainer", "0.5 0.5 0.5 0.8", transform: transform);
        }
    }
}
