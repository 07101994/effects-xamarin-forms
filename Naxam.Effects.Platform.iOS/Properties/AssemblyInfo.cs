using System.Reflection;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Naxam.Effects.Platform.iOS;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Naxam.Effects.Platform.iOS")]
[assembly: AssemblyDescription("Effects for Xamarin.Forms controls")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Naxam Company Limited")]
[assembly: AssemblyProduct("Xamarin.Forms Controls")]
[assembly: AssemblyCopyright("(c) 2017 Naxam")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.4")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
[assembly: ResolutionGroupName("Naxam.Effects")]
[assembly: ExportEffect(typeof(ListViewEffectNoSelection), "ListViewEffectNoSelection")]
[assembly: ExportEffect(typeof(ImageEffectColorized), "ImageEffectColorized")]
[assembly: ExportEffect(typeof(GestureEffectSwipe), "GestureEffectSwipe")]
[assembly: ExportEffect(typeof(EntryEffectNoBorder), "EntryEffectNoBorder")]