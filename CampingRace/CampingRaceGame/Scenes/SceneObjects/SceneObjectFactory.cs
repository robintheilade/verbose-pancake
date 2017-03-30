using Microsoft.Xna.Framework;

namespace CampingRaceGame.Scenes.SceneObjects
{
    public class SceneObjectFactory : ISceneObjectFactory
    {
        private readonly Game game;

        public SceneObjectFactory(Game game)
        {
            this.game = game;
        }

        public SceneObject CreateTree()
        {
            var sceneObject = new SceneObject();
            sceneObject.Components.Add(new SpriteSceneObjectComponent(sceneObject, "Textures/Tree", this.game));
            return sceneObject;
        }

        public SceneObject CreatePlayer()
        {
            var sceneObject = new SceneObject();
            sceneObject.Components.Add(new SpriteSceneObjectComponent(sceneObject, "Textures/Human", this.game));
            //sceneObject.Components.Add(new LocalInputSceneObjectComponent(sceneObject));
            return sceneObject;
        }
    }
}
