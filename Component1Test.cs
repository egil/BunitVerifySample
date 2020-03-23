using System;
using Xunit;
using Bunit;
using Verify;
using Bunit.Mocking.JSInterop;
using VerifyBunit;
using Xunit.Abstractions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BunitVerifySample
{
  public class Component1Test : VerifyBase
  {
    public Component1Test(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Component1RendersCorrectly_MarkupMatches()
    {
      var cut = RenderComponent<Component1>();

      cut.MarkupMatches(@"<div class=""my-component"">
                            This Blazor component is defined in the <strong>razorclasslib1</strong> package.
                          </div>");
    }

    [Fact]
    public Task Component1RendersCorrectly_Verify()
    {
      var cut = RenderComponent<Component1>();

      return Verify(cut);
    }
  }
}