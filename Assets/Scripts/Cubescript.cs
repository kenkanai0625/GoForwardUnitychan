using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubescript : MonoBehaviour {
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    public AudioClip block;
    AudioSource audioSource;



    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

        if (transform.position.y == 0)
        {
            audioSource.PlayOneShot(block);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Cube")
        {
            audioSource.PlayOneShot(block);
        }
        if (collision.gameObject.tag=="Ground" )
        {
            audioSource.PlayOneShot(block);
        }
    }



}
