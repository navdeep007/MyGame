using UnityEngine;
using System.Collections;

public class BusterGun : MonoBehaviour
{
    Animator mAnimator;
    bool mShooting;

    float kShootDuration = 0.25f;
    float mTime;

    public GameObject mBulletPrefab;
    MegaMan mMegaManRef;

    AudioSource mBusterSound;

    void Start ()
    {
        mAnimator = transform.parent.GetComponent<Animator>();
    

        mMegaManRef = transform.parent.GetComponent<MegaMan>();
        mBusterSound = transform.parent.GetComponent<AudioSource>();
        
    }

    void Update ()
    {
        if(Input.GetButtonDown ("Fire"))
        {
            
            GameObject bulletObject = Instantiate(mBulletPrefab, transform.position, Quaternion.identity);       
            Bullet bullet = bulletObject.GetComponent<Bullet>();       //Get the Bullet Component

       
            bullet.SetDirection(mMegaManRef.GetFacingDirection());

      
            mBusterSound.Play();

          
            mShooting = true;
            mTime = 0.0f;
        }

        if(mShooting)
        {
            mTime += Time.deltaTime;
            if(mTime > kShootDuration)
            {
                mShooting = false;
            }
        }

        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        mAnimator.SetBool ("isShooting", mShooting);
    }
}
