//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Texture2DComponent texture2D { get { return (Texture2DComponent)GetComponent(GameComponentsLookup.Texture2D); } }
    public bool hasTexture2D { get { return HasComponent(GameComponentsLookup.Texture2D); } }

    public void AddTexture2D(UnityEngine.Texture2D newTexture2D) {
        var index = GameComponentsLookup.Texture2D;
        var component = (Texture2DComponent)CreateComponent(index, typeof(Texture2DComponent));
        component.texture2D = newTexture2D;
        AddComponent(index, component);
    }

    public void ReplaceTexture2D(UnityEngine.Texture2D newTexture2D) {
        var index = GameComponentsLookup.Texture2D;
        var component = (Texture2DComponent)CreateComponent(index, typeof(Texture2DComponent));
        component.texture2D = newTexture2D;
        ReplaceComponent(index, component);
    }

    public void RemoveTexture2D() {
        RemoveComponent(GameComponentsLookup.Texture2D);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTexture2D;

    public static Entitas.IMatcher<GameEntity> Texture2D {
        get {
            if (_matcherTexture2D == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Texture2D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTexture2D = matcher;
            }

            return _matcherTexture2D;
        }
    }
}
