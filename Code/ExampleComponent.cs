using Sandbox;

public sealed class ExampleComponent : Component
{
  [Property]
  [Sync( SyncFlags.FromHost )]
  public bool ExampleProp { get; set; }

  protected override void OnStart()
  {
    ExampleProp = true;
  }
}
