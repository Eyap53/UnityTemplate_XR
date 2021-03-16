# Unity Template - XR

A template to start a XR project with Unity (beta version and URP rendering pipeline).

It already has :
- gitignore configured.
- git lfs set up with gitattributes.
- Editor configuration configured for C# writing conventions.
- Auto format on push, using github Actions and dotnet-format.
- The Unity project into a subfolder, with the starting packages for URP (including Shader Graph).
- New input system basic layout set-up.

XR specifics:
- Basic room for testing purposes.
- Packages necessary to XR.
- XR camera.

## How To: Add a new Headset brand ?

By default only the package for Oculus XR devices is added. If you want to support more headset brands, such as HTC-Vive, you need to add the appropriate packages. 
For HTC-Vive, you may want to add a scoped registery, see: https://github.com/ValveSoftware/unity-xr-plugin.

## Unlicense

This template is released into public domain. See the [UNLICENSE](./UNLICENSE) file.
