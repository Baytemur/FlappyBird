using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkKus : MonoBehaviour
{
    public int saniyedeKareSayisi = 10;
    public Sprite[] animasyonKareleri;

    private SpriteRenderer SpriteRenderer;

    private float sonrakiAnimasyonDegismeAni;
    private bool animasyonYonu = true;
    private int mevcutAnimasyonKaresi = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (animasyonKareleri.Length < 2)
            Destroy(this);

        SpriteRenderer = GetComponent<SpriteRenderer>();
        sonrakiAnimasyonDegismeAni = Time.time + 1f / saniyedeKareSayisi;

    }

    // Update is called once per frame
    void Update()
    {
        if ( Time.time >= sonrakiAnimasyonDegismeAni )
        {
            if (animasyonYonu)
            {
                if (mevcutAnimasyonKaresi == animasyonKareleri.Length - 1)
                {
                    mevcutAnimasyonKaresi--;
                    animasyonYonu = false;
                }
                else
                {
                    mevcutAnimasyonKaresi++;
                }
            }
            else
            {
                if (mevcutAnimasyonKaresi == 0 )
                {
                    mevcutAnimasyonKaresi++;
                    animasyonYonu = true;
                }
                else
                {
                    mevcutAnimasyonKaresi--;
                }
            }
            SpriteRenderer.sprite = animasyonKareleri[mevcutAnimasyonKaresi];
            sonrakiAnimasyonDegismeAni = Time.time + 1f / saniyedeKareSayisi;
            }
        }
    }
