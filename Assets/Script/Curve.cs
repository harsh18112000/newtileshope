using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

public class Curve : MonoBehaviour
{
    public BackGround bg;
    public Transform point1;
    public Transform point2;
    public Transform point3;


    public Transform player;

    public float speed;

    float movement;
    public Score score;
    private int index = 0;

    // public void Start()
    // {
    //     index = 0;
    //     nextMove();
    // }
    private void Start()
    {
        ballJump();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0f, 0);
        }
        //speed = (speed + Time.deltaTime) % 1.0f;
        movement += Time.deltaTime * speed;


        if (movement > 1)
            movement = 0;

        // transform.position = Moveplayernew(point1.position, point2.position, point3.position, movement);
        // transform.DOJump(bg.bgPool[bg.nextindex].transform.position, 0.15f, 1, 0.25f);
        // bg.curindex = bg.nextindex;
        // bg.nextindex++;
        // if (bg.curindex == bg.bgPool.Count - 1)
        // {
        //     bg.nextindex = 0;
        // }
    }

    async void ballJump()
    {
        Vector3 p11 = bg.bgPool[bg.curindex].transform.position;

        Vector3 p33 = bg.bgPool[bg.nextindex].transform.position;
        Vector3 pos = (p11 + p33) / 2f;
        Vector3 p22 = new Vector3(pos.x, pos.y + 3, pos.z);
        Vector3 target12 = Vector3.Lerp(p11, p22, speed);
        Vector3 target23 = Vector3.Lerp(p22, p33, speed);
        Vector3 AB_BC = Vector3.Lerp(target12, target23, speed);
        transform.position = AB_BC;
        await Task.Delay(2000);
        bg.curindex = bg.nextindex;
        bg.nextindex++;
        if (bg.nextindex == bg.bgPool.Count - 1)
        {
            bg.nextindex = 0;
        }
        ballJump();

        // Vector3 pos = (transform.position + bg.bgPool[bg.nextindex].transform.position) / 2f;
        // transform.DOMove(new Vector3(pos.x, pos.y + 6, pos.z), 0.45f).OnComplete(() =>
        // {
        //     transform.DOMove(bg.bgPool[bg.nextindex].transform.position, 0.45f).OnComplete(() =>
        // {
        //     bg.curindex = bg.nextindex;
        //     bg.nextindex++;
        //     if (bg.nextindex == bg.bgPool.Count - 1)
        //     {
        //         bg.nextindex = 0;
        //     }
        //     ballJump();
        // });
        // });
        // // transform.DOJump(bg.bgPool[bg.nextindex].transform.position, 0.8f, 1, 1f).OnComplete(() =>
        // {
        //     bg.curindex = bg.nextindex;
        //     bg.nextindex++;
        //     if (bg.curindex == bg.bgPool.Count - 1)
        //     {
        //         bg.nextindex = 0;
        //     }
        //     ballJump();
        // });
    }
    void Moveplayernew(Vector3 p1, Vector3 p2, Vector3 p3, float speeds)

    {
        // p1 = bg.bgPool[bg.curindex].transform.position;
        // p2 = Vector3.zero;
        // p3 = bg.bgPool[bg.nextindex].transform.position;
        // p2 = (p3+p1)/2;
        // p2 = new Vector3(p2.x,p2.y,p2.z+1f);
        Vector3 target12 = Vector3.Lerp(p1, p2, speeds);
        Vector3 target23 = Vector3.Lerp(p2, p3, speeds);
        Vector3 AB_BC = Vector3.Lerp(target12, target23, speeds);
        transform.position = AB_BC; 

        if (transform.position == p3)
        {
            bg.curindex = bg.nextindex;
            bg.nextindex++;
            Debug.Log("bdhsavlfhdasi");
            if (bg.curindex == bg.bgPool.Count - 1)
            {
                bg.nextindex = 0;

                // }
                // }
                //  return AB_BC;
            }
            // IEnumerator ball(Vector3 p1, Vector3 p2, Vector3 p3, float speeds)
            // {
            //     Debug.Log($"{p1} {p2} {p3}");
            //     while (Vector3.Distance(transform.position, p3) >= 0.05f)
            //     {

            //         //Vector3.distance(nextindex < 0.5)
            //         Vector3 p11 = bg.bgPool[bg.curindex].transform.position;
            //         Vector3 p22 = Vector3.zero;
            //         Vector3 p33 = bg.bgPool[bg.nextindex].transform.position;
            //         // p2 = (p3+p1)/2;
            //         // p2 = new Vector3(p2.x,p2.y,p2.z+1f);
            //         Vector3 target12 = Vector3.Lerp(p11, p22, speeds);
            //         Vector3 target23 = Vector3.Lerp(p22, p33, speeds);
            //         Vector3 AB_BC = Vector3.Lerp(target12, target23, speeds);
            //         transform.position = AB_BC;
            //         Debug.Log(AB_BC);
            //         yield return new WaitForSeconds(0.1f);
            //     }
            //     transform.position = point3.position;
            //     nextMove();
            //     yield return null;

            // }


            // public void nextMove()
            // {
            //     Debug.Log($"{bg.bgPool.Count} {index} {(index + 1) % bg.bgPool.Count}");
            //     StartCoroutine(ball(bg.bgPool[index].position, Vector3.zero, bg.bgPool[(index + 1) % bg.bgPool.Count].position, movement));
            // }

            void OnCollisionEnter(Collision col)
            {
                if (col.collider.tag == "Cube")
                {
                    Debug.Log("harsh");
                    // nextMove();
                    score.scoreno += 5;
                    bg.curindex = bg.nextindex;
                    bg.nextindex++;
                    //Debug.Log("bdhsavlfhdasi");
                    if (bg.curindex == bg.bgPool.Count - 1)
                    {
                        bg.nextindex = 0;

                    }
                }//else if(col.collider.tag != "Cube")
                 //{
                 //  UIManager.instance.ChangeToGameOver();
                 //}
            }
        }
    }
}


