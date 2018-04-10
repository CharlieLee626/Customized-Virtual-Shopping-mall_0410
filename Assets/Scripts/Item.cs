using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {


    //class
    public enum Type {
        ___toys___, tricycle, traincart1, traincart2, train, rocket, mouse, horse, duck, car, ball, airplane, xylophone1, xylophone2, rhythmegg_gold, rhythmegg_green, rhythmegg_red, rhythmegg_blue, rhythmegg_yellow, piano_wood, piano_white, piano_yellow, piano_green, piano_pink, piano_blue, piano_black, maracas6, maracas5, maracas4, maracas3, maracas2, maracas1, harmonica7, harmonica6, harmonica5, harmonica4, harmonica3, harmonica2, harmonica1, flute_yellow, flute_red, flute_green, flute_blue, flute_white, flute_orange, flute_pink, flute_brown, drumandstick6, drumandstick5, drumandstick4, drumandstick3, drumandstick2, drumandstick1, toysnowman, toybell, toyball, GiftBox_Square_TypeB, GiftBox_Square_TypeA, GiftBox_Rectangle_TypeB, GiftBox_Rectangle_TypeA, GiftBox_Cylinder_TypeB, GiftBox_Cylinder_TypeA, ChristmasSock, CandyCaneWithBow, Candy, Candle_Small, BabyStroller05, BabyStroller04, BabyStroller03, BabyStroller02, BabyStroller01, Train_toy, Tank_toy, Ship_toy, Helicopter_toy, Duck_toy, ___toys____,

        ___food___, straberry, pear, kiwi, banana, apple, tinned_can3, tinned_can2, tinned_can1, tuna, squid, soup, milkbox, jar, corn, chips, cornbox, watermelon, sauce1, rollingpin, milkbottle, lemon, deeppan, cornflakes, board, apple_big, can4, can3, can2, can1, can, bottle4, bottle3, bottle2, bottle1, bottle, croissant_03_mid, croissant_03_low, croissant_02_mid, croissant_02_low, croissant_01_mid, croissant_01_low, ___food____,

        ___clothing___, hanging_tshirt_unity_white, tshirt_unity_yellow, tshirt_studio_black, hanging_tshirt_unity_red, hanging_tshirt_unity_green, hanging_tshirt_unity_blue, hanging_tshirt_unity_black, folded_tshirt_yellow, folded_tshirt_white, folded_tshirt_black, folded_tshirt_studio, folded_tshirt_red, folded_tshirt_pink, folded_tshirt_blue, trainers_white, trainers_green, trainers_blue, trainers_black, jeans_black, jacket, hat_yellow, hat_white, hat_brown, hat_blue, hat_black, mens_shoe8, mens_shoe7, mens_shoe6, mens_shoe5, mens_shoe4, mens_shoe3, mens_shoe2, mens_shoe1, lady_shoe16, lady_shoe15, lady_shoe14, lady_shoe13, lady_shoe12, lady_shoe11, lady_shoe10, lady_shoe9, lady_shoe8, lady_shoe7, lady_shoe6, lady_shoe5, lady_shoe4, lady_shoe3, lady_shoe2, lady_shoe1, ___clothing____,

        ___jewelry___, roundcut, rosecut, pearcut, oldsinglecut, schoolbag_3, schoolbag_2, schoolbag_1, backpack_3, backpack_2, backpack_1, object38, object36, object34, object32, object30, object24, object22, object16, object14, object26, object20, object18, object15, object10, object8, object6, object4, object99, object98, cylinder3, line32, line30, line28, line26, line24, line22, line20, line18, line17, line16, line15, line14, line13, line12, line11, line10, line9, line8, line7, line6, line5, line4, line3, object19, object014, object12, object006_1, object005_1, object005, object004_1, object003_3, object003_2, object003_1, object003, object002_3, object002_2, object002, object001_2, object001, line02_1, line02, box03, box02, suitcase11, suitcase9, suitcase8, suitcase6, suitcase5, briefcase13, briefcase12, briefcase11, briefcase10, briefcase7, briefcase6, briefcase5, briefcase3, bag24, bag23, bag22, bag21, bag20, bag19, bag18, bag17, bag16, bag15, bag12, bag11, bag10, bag9, bag8, bag4, ___jewelry____, 

        ___home___, sledge_hammer, ice_axe, hammer_black, hacksaw, crowbar_red, axe_darkwood, screwdriver, saw, hammer_small, box, axe_lightwood, spoon, soup_plate, saucer, saucepan, plate, pan, mug, ladle, knife_home_big, fork, cup, bowl, pillow4_maya, pillow7_red, pillow6_patrick_star_give_me_the_hat_will_you, pillow5_grey, pillow3_white, pillow1_militery, pillow_long_stripe, pillow_long_red, pillow_long_white, water_can_red, water_can_green, water_can_blue, wheel_barrow, water_can_grey, spanner, rake, prong, plunger, cylinder_brush, crowbar, chisel, bucket, broom, plastic_spoon, plastic_spork, table_fork, table_spoon, coffee_table_GG, coffee_table_dark, metal_stool, coffee_table3, ___home____, 

        ___outdoor___, tent_bag, survival_food, shovel, pillow_bottle, match_box, knife_outdoor, flask, flashlight_small, ducktape, compass, can_red, can_blue, can_green, book_b, book_o, binoculars, battery_small, battery_big, axe_small, axe_large, boiling_pot, frying_pan, tea_pot, ___outdoor____, 

        ___sport___, punchingbag, paddleyellow, paddleblue, gloves, dirtyfootball, basketballlight, darkvolleyball, tabletennis, rugby, golfball, basketball, volleyball_py, volleyball_y, volleyball_leather, volleyball_white, volleyball_yb, tennisball, golfball_a, golfball_b, football_yellow, football_dirty, football_red, football_white, football_origin, basketball_girl, basketball_street, basketball_black, basketball_wob, basketball_origin, bodyboard_stripe, bodyboard_green, bodyboard_ocean, bodyboard_red, bodyboard_blue, beachbat_y, beachbat_stripe, ___sport____, 

        ___3c___, smartphone, blackkeyboard, blackmouse, tv, speaker, pc_speaker, desktop, whitenotebook, whitemouse, monitor, whitekeyboard, goldlaptop, macbook, ___3c____, 

        shoe, blacksneaker, Sphere, sunglasses, sportsunglasses, cap, cat, flashlight, knife, piano, atomball, buckyball, boat,  strawberry
         
        
    }

    //object
    public bool InShoppingCart = false;
    public Type ItemType;
    public float price;
    //    public GameObject Info;
    //    public int collidernum;

    public void Init(Type itemType, float price, int collidenum)
    {
        this.ItemType = itemType;
        this.price = price;

        /*if (this.ItemType == Type.buckyball)
        {
            this.GetComponent<PhotonView>().TransferOwnership(0);
            if (this.GetComponent<PhotonView>().ownerId == PhotonNetwork.player.ID)
            {
                Debug.Log("Not requesting ownership. Already mine.");
                return;
            }

            this.GetComponent<PhotonView>().RequestOwnership();
        }*/

        //this.collidernum = collidernum;
    }
  

    public void itemToss()
    {
        // if the item is thrown into the trashcan destroy the item
    }
    public void createNewItem()
    {
        // one a item is destroyed, a new item must be generated based in the latent item list(produced initially by the type in the look-up table ) 
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (this.ItemType == Type.flashlight)
        {
            if (this.transform.position.y < 0.05)
            {
                this.gameObject.transform.position = new Vector3((float)2.8, (float)0.8, (float)2.34);
                this.gameObject.transform.rotation = Quaternion.Euler (new Vector3(-90, 180, 90));
            }
        }
  
        /*
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player);

        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<PhotonView>().TransferOwnership(0);
        }
        
      

        if(this.GetComponent<Collider>().attachedRigidbody.isKinematic)
        {
            Info.SetActive(true);
        }
        else
        {
            Info.SetActive(false);
        }*/
    }
}


