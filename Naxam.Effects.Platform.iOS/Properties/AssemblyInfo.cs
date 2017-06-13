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
[assembly: AssemblyProduct("X Controls")]
[assembly: AssemblyCopyright("Copyright (c) 2017 Naxam")]
[assembly: AssemblyTrademark("NAXAM")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.6.1")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
[assembly: ResolutionGroupName("Naxam.Effects")]
[assembly: ExportEffect(typeof(ListViewEffectNoSelection), "ListViewEffectNoSelection")]
[assembly: ExportEffect(typeof(ImageEffectColorized), "ImageEffectColorized")]
[assembly: ExportEffect(typeof(GestureEffectSwipe), "GestureEffectSwipe")]
[assembly: ExportEffect(typeof(EntryEffectNoBorder), "EntryEffectNoBorder")]
[assembly: ExportEffect(typeof(ViewStyleEffect), "ViewStyleEffect")]
[assembly: ExportEffect(typeof(RoundedViewEffect), "RoundedViewEffect")]
[assembly: ExportEffect(typeof(TakeSnapshotEffect), "TakeSnapshotEffect")]