using UnityEngine;
public class manager : MonoBehaviour
{
    // triangulo para ser clonado
    public GameObject triangulo;
    // Array com os triangulos
    public GameObject[] trianguloArray;
    // Array dos pivo
    public GameObject[] vetGameObj;

    public GameObject BaseDoVermelho;
    public GameObject MeioDoVermelho;
    public GameObject TopoDoVermelho;

    public GameObject BaseDoAmarelo;
    public GameObject MeioDoAmarelo;
    public GameObject TopoDoAmarelo;

    public GameObject BaseDoAzul;
    public GameObject MeioDoAzul;
    public GameObject TopoDoAzul;

    public GameObject BaseDoRosa;
    public GameObject MeioDoRosa;
    public GameObject TopoDoRosa;

    GameObject pai;

    void Start()
    {
        trianguloArray = new GameObject[22];
        vetGameObj = new GameObject[22];
        // Cria os triangulos e os pivo
        for (int i = 0; i < 22; i++)
        {
            // Cria um pivo
            vetGameObj[i] = new GameObject();
            // Define a posição inicial de cada pivo
            vetGameObj[i].transform.position = new Vector3(0, 0, 0);
            // Da um nome para cada pivo
            vetGameObj[i].name = "Pivo " + i;
            // Cria um triangulo
            GameObject trianguloClone = Instantiate(triangulo, new Vector3(-0.5f, -0.28f, -0.28f), Quaternion.identity);
            // Define a escala do triangulo criado
            trianguloClone.transform.localScale = Vector3.one;
            // Enfia o triangulo no array
            trianguloArray[i] = trianguloClone;
            // Da um nome pro triangulo
            trianguloArray[i].name = "Triangulo " + i;
            // Envia o triangulo no pivo            
            trianguloArray[i].transform.parent = vetGameObj[i].transform;
        }

        // Rosa
        vetGameObj[1].transform.position = new Vector3(1, 0, 0);
        vetGameObj[2].transform.position = new Vector3(2, 0, 0);
        vetGameObj[3].transform.position = new Vector3(0.5f, 0.194f, 0.07f);
        vetGameObj[3].transform.Rotate(36.1f, 0.0f, 180.0f);
        vetGameObj[4].transform.position = new Vector3(1.5f, 0.194f, 0.07f);
        vetGameObj[4].transform.Rotate(36.1f, 0.0f, 180.0f);
        vetGameObj[5].transform.position = new Vector3(0.5f, 0.856f, 0.289f);
        vetGameObj[6].transform.position = new Vector3(1.5f, 0.856f, 0.289f);
        vetGameObj[7].transform.position = new Vector3(1f, 1.05f, 0.35f);
        vetGameObj[7].transform.Rotate(37.2f, 0.0f, 180.0f);
        vetGameObj[8].transform.position = new Vector3(1, 1.72f, 0.577f);

        // Azul
        vetGameObj[9].transform.position = new Vector3(0.5f, 0, 0.3f);
        vetGameObj[9].transform.Rotate(0.0f, 180.0f, 0f);
        vetGameObj[10].transform.position = new Vector3(1.5f, 0, 0.3f);
        vetGameObj[10].transform.Rotate(0.0f, 180.0f, 0f);
        vetGameObj[11].transform.position = new Vector3(0.5f, 0, 0.86f);
        vetGameObj[12].transform.position = new Vector3(1.5f, 0, 0.86f);
        vetGameObj[13].transform.position = new Vector3(1.0f, 0, 1.165f);
        vetGameObj[13].transform.Rotate(0.0f, 180.0f, 0f);
        vetGameObj[14].transform.position = new Vector3(1.0f, 0, 1.72f);

        // Vermelho
        vetGameObj[15].transform.position = new Vector3(0.3046848f, 0.2528399f, 0.366502f);
        vetGameObj[15].transform.Rotate(-53.237f, 3.649f, 32.34f);
        vetGameObj[16].transform.position = new Vector3(vetGameObj[15].transform.position.x + 0.5f, vetGameObj[15].transform.position.y, vetGameObj[15].transform.position.z + 0.86f);
        vetGameObj[16].transform.Rotate(-53.237f, 3.649f, 32.34f);
        vetGameObj[17].transform.position = new Vector3(1.0f, 0.856f, 1.1f);
        vetGameObj[18].transform.position = new Vector3(0.8f, 1.1f, 0.66f);
        vetGameObj[18].transform.Rotate(-54.71f, 7.715f, 26.595f);

        // Amarelo
        vetGameObj[19].transform.position = new Vector3(1.11f, 1.101006f, 0.700864f);
        vetGameObj[19].transform.Rotate(38.804f, 34.142f, 47.602f);
        vetGameObj[20].transform.position = new Vector3(1.129233f, 0.231463f, 1.29255f);
        vetGameObj[20].transform.Rotate(38.68f, 36.725f, 45.643f);
        vetGameObj[21].transform.position = new Vector3(1.657f, 0.29f, 0.426f);
        vetGameObj[21].transform.Rotate(38.68f, 36.725f, 45.643f);

        // base Azul
        TopoDoVermelho.transform.position = new Vector3((vetGameObj[0].transform.position.x + vetGameObj[2].transform.position.x + vetGameObj[14].transform.position.x) / 3.0f,
        (vetGameObj[0].transform.position.y + vetGameObj[2].transform.position.y + vetGameObj[14].transform.position.y) / 3.0f,
        (vetGameObj[0].transform.position.z + vetGameObj[2].transform.position.z + vetGameObj[14].transform.position.z) / 3.0f);

        //base Rosa
        BaseDoAmarelo.transform.position = new Vector3((vetGameObj[0].transform.position.x + vetGameObj[2].transform.position.x + vetGameObj[8].transform.position.x) / 3.0f,
        (vetGameObj[0].transform.position.y + vetGameObj[2].transform.position.y + vetGameObj[8].transform.position.y) / 3.0f,
        (vetGameObj[0].transform.position.z + vetGameObj[2].transform.position.z + vetGameObj[8].transform.position.z) / 3.0f);

        //base Amarelo
        BaseDoRosa.transform.position = new Vector3((vetGameObj[14].transform.position.x + vetGameObj[2].transform.position.x + vetGameObj[8].transform.position.x) / 3.0f,
        (vetGameObj[14].transform.position.y + vetGameObj[2].transform.position.y + vetGameObj[8].transform.position.y) / 3.0f,
        (vetGameObj[14].transform.position.z + vetGameObj[2].transform.position.z + vetGameObj[8].transform.position.z) / 3.0f);

        //base Vermelha
        TopoDoAzul.transform.position = new Vector3((vetGameObj[0].transform.position.x + vetGameObj[14].transform.position.x + vetGameObj[8].transform.position.x) / 3.0f,
        (vetGameObj[0].transform.position.y + vetGameObj[14].transform.position.y + vetGameObj[8].transform.position.y) / 3.0f,
        (vetGameObj[0].transform.position.z + vetGameObj[14].transform.position.z + vetGameObj[8].transform.position.z) / 3.0f);

        //superior 1
        TopoDoVermelho.transform.position = new Vector3((vetGameObj[5].transform.position.x + vetGameObj[6].transform.position.x + vetGameObj[17].transform.position.x) / 3.0f,
        (vetGameObj[5].transform.position.y + vetGameObj[6].transform.position.y + vetGameObj[17].transform.position.y) / 3.0f,
        (vetGameObj[5].transform.position.z + vetGameObj[6].transform.position.z + vetGameObj[17].transform.position.z) / 3.0f);

        //superior 2
        TopoDoRosa.transform.position = new Vector3((vetGameObj[5].transform.position.x + vetGameObj[11].transform.position.x + vetGameObj[1].transform.position.x) / 3.0f,
        (vetGameObj[5].transform.position.y + vetGameObj[11].transform.position.y + vetGameObj[1].transform.position.y) / 3.0f,
        (vetGameObj[5].transform.position.z + vetGameObj[11].transform.position.z + vetGameObj[1].transform.position.z) / 3.0f);

        //superior 3
        TopoDoAzul.transform.position = new Vector3((vetGameObj[1].transform.position.x + vetGameObj[6].transform.position.x + vetGameObj[12].transform.position.x) / 3.0f,
        (vetGameObj[1].transform.position.y + vetGameObj[6].transform.position.y + vetGameObj[12].transform.position.y) / 3.0f,
        (vetGameObj[1].transform.position.z + vetGameObj[6].transform.position.z + vetGameObj[12].transform.position.z) / 3.0f);

        //superior 4
        TopoDoAmarelo.transform.position = new Vector3((vetGameObj[12].transform.position.x + vetGameObj[11].transform.position.x + vetGameObj[17].transform.position.x) / 3.0f,
        (vetGameObj[12].transform.position.y + vetGameObj[11].transform.position.y + vetGameObj[17].transform.position.y) / 3.0f,
        (vetGameObj[12].transform.position.z + vetGameObj[11].transform.position.z + vetGameObj[17].transform.position.z) / 3.0f);

        //Pontas
        TopoDoVermelho.transform.position = vetGameObj[8].transform.position;
        TopoDoRosa.transform.position = vetGameObj[0].transform.position;
        TopoDoAzul.transform.position = vetGameObj[2].transform.position;
        TopoDoAmarelo.transform.position = vetGameObj[14].transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.x > 0.98f && vetGameObj[i].transform.position.x < 2.1f && vetGameObj[i].transform.position.z > -0.02f && vetGameObj[i].transform.position.z < 0.92f && vetGameObj[i].transform.position.y < 0.90f)
                    vetGameObj[i].transform.parent = TopoDoAzul.transform;
            }
            TopoDoAzul.transform.Rotate(0.0f, 30.0f, 0.0f);
        }

        if (Input.GetKeyDown("s"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.z >= -0.01f && vetGameObj[i].transform.position.z < 1.82f && vetGameObj[i].transform.position.x > -0.0001f && vetGameObj[i].transform.position.x < 1.20f
                && !(vetGameObj[i].transform.position.z >= -0.01f && vetGameObj[i].transform.position.z < 0.05f && vetGameObj[i].transform.position.x >= 0.98f && vetGameObj[i].transform.position.x < 1.02f))
                {
                    vetGameObj[i].transform.parent = TopoDoAzul.transform;
                }
            }
            TopoDoAzul.transform.Rotate(0.0f, 30.0f, 0.0f);
        }
        if (Input.GetKeyDown("d"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.z >= 0.82f && vetGameObj[i].transform.position.z < 1.8f)
                    vetGameObj[i].transform.parent = TopoDoAmarelo.transform;
            }
            TopoDoAmarelo.transform.Rotate(0.0f, 30.0f, 0.0f);
        }
        if (Input.GetKeyDown("f"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.z >= -0.50f && vetGameObj[i].transform.position.z < 0.80f)
                    vetGameObj[i].transform.parent = BaseDoAmarelo.transform;
            }
            BaseDoAmarelo.transform.Rotate(0.0f, 30.0f, 0.0f);
        }
        if (Input.GetKeyDown("g"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.y >= 0.85f && vetGameObj[i].transform.position.y < 1.2f)
                    vetGameObj[i].transform.parent = TopoDoVermelho.transform;
            }
            TopoDoVermelho.transform.Rotate(0.0f, 30.0f, 0.0f);
        }
        if (Input.GetKeyDown("h"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.y >= -0.100f && vetGameObj[i].transform.position.y <= 0.3000f)
                    vetGameObj[i].transform.parent = TopoDoVermelho.transform;
            }
            TopoDoVermelho.transform.Rotate(0.0f, 30.0f, 0.0f);
        }
        if (Input.GetKeyDown("q"))
        {
            vetGameObj[14].transform.parent = TopoDoAmarelo.transform;
            TopoDoAmarelo.transform.Rotate(0.0f, 30.0f, 0.0f);
        }

        if (Input.GetKeyDown("w"))
        {
            vetGameObj[2].transform.parent = TopoDoAzul.transform;
            TopoDoAzul.transform.Rotate(0.0f, 30.0f, 0.0f);
        }

        if (Input.GetKeyDown("e"))
        {
            vetGameObj[8].transform.parent = TopoDoVermelho.transform;
            TopoDoVermelho.transform.Rotate(0.0f, 30.0f, 0.0f);
        }

        if (Input.GetKeyDown("r"))
        {
            vetGameObj[0].transform.parent = TopoDoRosa.transform;
            TopoDoRosa.transform.Rotate(0.0f, 30.0f, 0.0f);
        }

        if (Input.GetKeyDown("t"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.x > -0.02f && vetGameObj[i].transform.position.x < 1.02f && vetGameObj[i].transform.position.z > -0.02f && vetGameObj[i].transform.position.z < 0.89f && vetGameObj[i].transform.position.y < 0.90f)
                    vetGameObj[i].transform.parent = TopoDoRosa.transform;
            }
            TopoDoRosa.transform.Rotate(0.0f, 30.0f, 0.0f);
        }

        if (Input.GetKeyDown("y"))
        {
            for (int i = 0; i < 22; i++)
            {
                if (vetGameObj[i].transform.position.x > 0.79f && vetGameObj[i].transform.position.x < 2.04f && vetGameObj[i].transform.position.z >= -0.01f && vetGameObj[i].transform.position.z < 1.75f
                && !(vetGameObj[i].transform.position.z >= -0.01f && vetGameObj[i].transform.position.z < 0.05f && (vetGameObj[i].transform.position.x > -0.02f && vetGameObj[i].transform.position.x < 0.03f ||
                vetGameObj[i].transform.position.x > 0.98f && vetGameObj[i].transform.position.x < 1.02f)))
                {
                    vetGameObj[i].transform.parent = BaseDoRosa.transform;
                }
            }
            BaseDoRosa.transform.Rotate(0.0f, 30.0f, 0.0f);
        }

    }
}