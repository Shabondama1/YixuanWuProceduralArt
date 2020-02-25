using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Art
{
    public class Artworkmaker : ArtMakerTemplate
    {
        public GameObject[] objects;
        public GameObject cube;
        int amount = 2;

        public override void MakeArt()
        {
            //cube.SetActive(true);
            //cube.renderer.enabled = true;
            Instantiate(cube);

            int index = Random.Range(0, objects.Length);
            int oldIndex;

            for (int i = 0; i < amount; i++)
            {
                GameObject cube = new GameObject();
                MeshFilter filter = cube.AddComponent<MeshFilter>();
                cube.AddComponent<MeshRenderer>();

                GameObject z = Instantiate(objects[index]);
                oldIndex = index;

                while (index == oldIndex)
                {
                    index = Random.Range(0, objects.Length);
                }

                z.transform.parent = root.transform;
                float s = Random.value * .8f;
                float t = Random.value * .1f;

                z.transform.localScale = new Vector3(1-s, 1-s, 1-s);
                z.transform.position = new Vector3 (0, t, 0);
            }
        }
    }
}