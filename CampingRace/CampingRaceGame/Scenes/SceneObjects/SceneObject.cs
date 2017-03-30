using System.Collections.Generic;

namespace CampingRaceGame.Scenes.SceneObjects
{
    public class SceneObject
    {
        public List<ISceneObjectComponent> Components
        {
            get;
            private set;
        }

        public SceneObject()
        {
            this.Components = new List<ISceneObjectComponent>();
        }

        public void Draw()
        {
        }
    }
}
