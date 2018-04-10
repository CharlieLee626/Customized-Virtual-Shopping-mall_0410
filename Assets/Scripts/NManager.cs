using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NManager : MonoBehaviour {

    public GameObject headPrefabs;
    public GameObject leftHandPrefabs;
    public GameObject rightHandPrefabs;

    public GameObject BuckyBall;
    //store 1
    public GameObject one_smartphone;
    public GameObject one_laptop_2;
    public GameObject one_laptop_1;
    public GameObject one_laptop;
    public GameObject one_PCKeyboard;
    public GameObject one_Mouse;
    public GameObject one_tv;
    public GameObject one_speaker;
    public GameObject one_pc_speaker;
    public GameObject one_pc;
    public GameObject one_notebook;
    public GameObject one_mouse;
    public GameObject one_monitor;
    public GameObject one_keyboard;
    //store 2
    public GameObject two_PunchingBag_Prefab;
    public GameObject two_Paddle_Yellow;
    public GameObject two_Paddle_Blue;
    public GameObject two_Gloves_Dark;
    public GameObject two_Football_White;
    public GameObject two_Basketball_Light;
    public GameObject two_volleyBallF;
    public GameObject two_TableTennisF;
    public GameObject two_rugbyF;
    public GameObject two_golfBallF;
    public GameObject two_basketball;
    public GameObject two_prop_volleyball_e;
    public GameObject two_prop_volleyball_d;
    public GameObject two_prop_volleyball_c;
    public GameObject two_prop_volleyball_b;
    public GameObject two_prop_volleyball_a;
    public GameObject two_prop_tennis_ball_a;
    public GameObject two_prop_golf_ball_b;
    public GameObject two_prop_golf_ball_a;
    public GameObject two_prop_football_e;
    public GameObject two_prop_football_d;
    public GameObject two_prop_football_c;
    public GameObject two_prop_football_b;
    public GameObject two_prop_football_a;
    public GameObject two_prop_basketball_e;
    public GameObject two_prop_basketball_d;
    public GameObject two_prop_basketball_c;
    public GameObject two_prop_basketball_b;
    public GameObject two_prop_basketball_a;
    public GameObject two_Bodyboard_5;
    public GameObject two_Bodyboard_4;
    public GameObject two_Bodyboard_3;
    public GameObject two_Bodyboard_2;
    public GameObject two_Bodyboard_1;
    public GameObject two_BeachBat3;
    public GameObject two_BeachBat1;
    //store 3
    public GameObject three_Tent_Bag;
    public GameObject three_Survival_Food;
    public GameObject three_Shovel;
    public GameObject three_PillBottle;
    public GameObject three_Matches_Box;
    public GameObject three_Knife;
    public GameObject three_Flask;
    public GameObject three_Flashlight;
    public GameObject three_DucktTape;
    public GameObject three_Compass;
    public GameObject three_Can_3;
    public GameObject three_Can_2;
    public GameObject three_Can_1;
    public GameObject three_Book_2;
    public GameObject three_Book_1;
    public GameObject three_Binoculars;
    public GameObject three_Battery_2;
    public GameObject three_Battery_1;
    public GameObject three_Axe_Small;
    public GameObject three_Axe_Large;
    public GameObject three_BoilingPot_Small_BackPacking;
    public GameObject three_FryingPan_Small_BackPacking;
    public GameObject three_TeaPot_Backpacking;
    //store 4
    public GameObject four_sledgeHammer;
    public GameObject four_IceAxe;
    public GameObject four_hammer1;
    public GameObject four_hacksaw;
    public GameObject four_crowbar1;
    public GameObject four_axe;
    public GameObject four_Screwdriver;
    public GameObject four_Saw;
    public GameObject four_Hammer;
    public GameObject four_Box;
    public GameObject four_Axe;
    public GameObject four_spoon;
    public GameObject four_soup_plate_high_poly;
    public GameObject four_saucer_high_poly;
    public GameObject four_saucepan_big;
    public GameObject four_plate_high_poly;
    public GameObject four_pan_high_poly;
    public GameObject four_mug_high_poly;
    public GameObject four_ladle_high_poly;
    public GameObject four_knife_big;
    public GameObject four_fork;
    public GameObject four_PlasticSpoon;
    public GameObject four_cup_high_poly;
    public GameObject four_bowl_high_poly;
    public GameObject four_P4_short;
    public GameObject four_P7_short;
    public GameObject four_P6_short;
    public GameObject four_P5_short;
    public GameObject four_P3_short;
    public GameObject four_P1_short;
    public GameObject four_Long_4;
    public GameObject four_Long_2;
    public GameObject four_Long_1;
    public GameObject four_watering_can_red;
    public GameObject four_watering_can_green;
    public GameObject four_watering_can_blue;
    public GameObject four_wheel_barrow_blue;
    public GameObject four_watering_can;
    public GameObject four_spanner;
    public GameObject four_PlasticSpork;
    public GameObject four_rake;
    public GameObject four_prong;
    public GameObject four_TableFork;
    public GameObject four_TableSppon;
    public GameObject four_WoodCoffeeTable;
    public GameObject four_MetalStool;
    public GameObject four_plunger;
    public GameObject four_cylinder_brush_blue;
    public GameObject four_crowbar;
    public GameObject four_chisel;
    public GameObject four_bucket;
    public GameObject four_broom;
    public GameObject four_WoodedCoffeeTable2;

    //stor5
    public GameObject five_RoundCut;
    public GameObject five_RoseCut;
    public GameObject five_PearCut;
    public GameObject five_OldSingleCut;
    public GameObject five_school_bag_3;
    public GameObject five_school_bag_2;
    public GameObject five_school_bag_1;
    public GameObject five_backpack_3;
    public GameObject five_backpack_2;
    public GameObject five_backpack_1;
    public GameObject five_Object038;
    public GameObject five_Object036;
    public GameObject five_Object034;
    public GameObject five_Object032;
    public GameObject five_Object030;
    public GameObject five_Object024;
    public GameObject five_Object022;
    public GameObject five_Object016;
    public GameObject five_Object14;
    public GameObject five_Object026;
    public GameObject five_Object020;
    public GameObject five_Object018;
    public GameObject five_Object15;
    public GameObject five_Object010;
    public GameObject five_Object008;
    public GameObject five_Object006;
    public GameObject five_Object004;
    public GameObject five_Object99;
    public GameObject five_Object98;
    public GameObject five_Cylinder03;
    public GameObject five_Line32;
    public GameObject five_Line30;
    public GameObject five_Line28;
    public GameObject five_Line26;
    public GameObject five_Line24;
    public GameObject five_Line22;
    public GameObject five_Line20;
    public GameObject five_Line18;
    public GameObject five_Line17;
    public GameObject five_Line16;
    public GameObject five_Line15;
    public GameObject five_Object003_2;
    public GameObject five_Object003_1;
    public GameObject five_Object003;
    public GameObject five_Object002_3;
    public GameObject five_Object002_2;
    public GameObject five_Object002;
    public GameObject five_Object001_2;
    public GameObject five_Line02_1;
    public GameObject five_Line02;
    public GameObject five_suitcase11;
    public GameObject five_suitcase9;
    public GameObject five_suitcase8;
    public GameObject five_suitcase6;
    public GameObject five_suitcase5;
    public GameObject five_briefcase13;
    public GameObject five_briefcase12;
    public GameObject five_briefcase11;
    public GameObject five_briefcase10;
    public GameObject five_briefcase7;
    public GameObject five_briefcase6;
    public GameObject five_briefcase5;
    public GameObject five_briefcase3;
    public GameObject five_bag24;
    public GameObject five_bag23;
    public GameObject five_bag22;
    public GameObject five_bag21;
    public GameObject five_bag20;
    public GameObject five_bag19;
    public GameObject five_bag18;
    public GameObject five_bag17;
    public GameObject five_bag16;
    public GameObject five_bag15;
    public GameObject five_bag12;
    public GameObject five_bag11;
    public GameObject five_bag10;
    public GameObject five_bag9;
    public GameObject five_bag8;
    public GameObject five_bag4;

    //store 6
    public GameObject six_TShirt_Hanging_White_Unity;
    public GameObject six_TShirt_Hanging_Yellow;
    public GameObject six_TShirt_Hanging_RivermillStudios;
    public GameObject six_TShirt_Hanging_Red;
    public GameObject six_TShirt_Hanging_Green;
    public GameObject six_TShirt_Hanging_Blue;
    public GameObject six_TShirt_Hanging_Black_Unity;
    public GameObject six_TShirt_Folded_Yellow;
    public GameObject six_TShirt_Folded_Unity_White;
    public GameObject six_TShirt_Folded_Unity_Black;
    public GameObject six_TShirt_Folded_RivermillStudios;
    public GameObject six_TShirt_Folded_Red;
    public GameObject six_TShirt_Folded_Pink;
    public GameObject six_TShirt_Folded_Blue;
    public GameObject six_Trainers_white;
    public GameObject six_Trainers_Green;
    public GameObject six_Trainers_Blue;
    public GameObject six_Trainers_Black;
    public GameObject six_Jeans_Black;
    public GameObject six_Jacket;
    public GameObject six_Hat_Yellow;
    public GameObject six_Hat_White;
    public GameObject six_Hat_Brown;
    public GameObject six_Hat_Blue;
    public GameObject six_Hat_Black;
    public GameObject six_mens_shoe8;
    public GameObject six_mens_shoe7;
    public GameObject six_mens_shoe6;
    public GameObject six_mens_shoe5;
    public GameObject six_mens_shoe4;
    public GameObject six_mens_shoe3;
    public GameObject six_mens_shoe2;
    public GameObject six_mens_shoe1;
    public GameObject six_lady_shoe16;
    public GameObject six_lady_shoe15;
    public GameObject six_lady_shoe14;
    public GameObject six_lady_shoe13;
    public GameObject six_lady_shoe12;
    public GameObject six_lady_shoe11;
    public GameObject six_lady_shoe10;
    public GameObject six_lady_shoe9;
    public GameObject six_lady_shoe8;
    public GameObject six_lady_shoe7;
    public GameObject six_lady_shoe6;
    public GameObject six_lady_shoe5;
    public GameObject six_lady_shoe4;
    public GameObject six_lady_shoe3;
    public GameObject six_lady_shoe2;
    public GameObject six_lady_shoe1;

    //store7
    public GameObject seven_Strawberry;
    public GameObject seven_Pear;
    public GameObject seven_Kiwi;
    public GameObject seven_Banana;
    public GameObject seven_Apple1;
    public GameObject seven_Can_3;
    public GameObject seven_Can_2;
    public GameObject seven_Can_1;
    public GameObject seven_tuna;
    public GameObject seven_squid;
    public GameObject seven_soup;
    public GameObject seven_milk;
    public GameObject seven_jar;
    public GameObject seven_corn;
    public GameObject seven_chips;
    public GameObject seven_cornbox;
    public GameObject seven_WaterMElon;
    public GameObject seven_Sauce1;
    public GameObject seven_RollingPin;
    public GameObject seven_Milk;
    public GameObject seven_Lemon;
    public GameObject seven_deeppan;
    public GameObject seven_CornFlakes;
    public GameObject seven_Board;
    public GameObject seven_Apple;
    public GameObject seven_Can4;
    public GameObject seven_Can3;
    public GameObject seven_Can2;
    public GameObject seven_Can1;
    public GameObject seven_Can;
    public GameObject seven_Bottle4;
    public GameObject seven_Bottle3;
    public GameObject seven_Bottle2;
    public GameObject seven_Bottle1;
    public GameObject seven_Bottle;
    public GameObject seven_croissant_03_mid;
    public GameObject seven_croissant_03_low;
    public GameObject seven_croissant_02_mid;
    public GameObject seven_croissant_02_low;
    public GameObject seven_croissant_01_mid;
    public GameObject seven_croissant_01_low;

    //store 8
    public GameObject eight_Tricycle;
    public GameObject eight_TrainCart2;
    public GameObject eight_TrainCart1;
    public GameObject eight_Train;
    public GameObject eight_Rocket;
    public GameObject eight_Mouse;
    public GameObject eight_Horse;
    public GameObject eight_Duck;
    public GameObject eight_Car;
    public GameObject eight_Ball;
    public GameObject eight_Airplane;
    public GameObject eight_xylophone2;
    public GameObject eight_xylophone1;
    public GameObject eight_rhythmegg5;
    public GameObject eight_rhythmegg4;
    public GameObject eight_rhythmegg3;
    public GameObject eight_rhythmegg2;
    public GameObject eight_rhythmegg1;
    public GameObject eight_piano7;
    public GameObject eight_piano6;
    public GameObject eight_piano5;
    public GameObject eight_piano4;
    public GameObject eight_piano3;
    public GameObject eight_piano2;
    public GameObject eight_piano1;
    public GameObject eight_maracas6;
    public GameObject eight_maracas5;
    public GameObject eight_maracas4;
    public GameObject eight_maracas3;
    public GameObject eight_maracas2;
    public GameObject eight_maracas1;
    public GameObject eight_harmonica7;
    public GameObject eight_harmonica6;
    public GameObject eight_harmonica5;
    public GameObject eight_harmonica4;
    public GameObject eight_harmonica3;
    public GameObject eight_harmonica2;
    public GameObject eight_harmonica1;
    public GameObject eight_flute8;
    public GameObject eight_flute7;
    public GameObject eight_flute6;
    public GameObject eight_flute5;
    public GameObject eight_flute4;
    public GameObject eight_flute3;
    public GameObject eight_flute2;
    public GameObject eight_flute1;
    public GameObject eight_drumandstick6;
    public GameObject eight_drumandstick5;
    public GameObject eight_drumandstick4;
    public GameObject eight_drumandstick3;
    public GameObject eight_drumandstick2;
    public GameObject eight_drumandstick1;
    public GameObject eight_Toy_Snowman;
    public GameObject eight_Toy_Bell;
    public GameObject eight_Toy_Ball;
    public GameObject eight_GiftBox_Square_TypeB;
    public GameObject eight_GiftBox_Square_TypeA;
    public GameObject eight_GiftBox_Rectangle_TypeB;
    public GameObject eight_GiftBox_Rectangle_TypeA;
    public GameObject eight_GiftBox_Cylinder_TypeB;
    public GameObject eight_GiftBox_Cylinder_TypeA;
    public GameObject eight_ChristmasSock;
    public GameObject eight_CandyCaneWithBow;
    public GameObject eight_Candy;
    public GameObject eight_Candle_Small;
    public GameObject eight_BabyStroller04;
    public GameObject eight_Train_toy;
    public GameObject eight_Tank_toy;
    public GameObject eight_Ship_toy;
    public GameObject eight_Helicopter_toy;
    public GameObject eight_Duck_toy;


    public virtual void Start()
    {
            PhotonNetwork.ConnectUsingSettings("1.0");
    }


    // below, we implement some callbacks of PUN
    // you can find PUN's callbacks in the class PunBehaviour or in enum PhotonNetworkingMessage


    public virtual void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
        PhotonNetwork.JoinRandomRoom();
    }

    public virtual void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();");
        PhotonNetwork.JoinRandomRoom();
    }

    public virtual void OnPhotonRandomJoinFailed()
    {
        Debug.Log("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);");
        PhotonNetwork.CreateRoom(null, new RoomOptions() { MaxPlayers = 4 }, null);
    }

    // the following methods are implemented to give you some context. re-implement them as needed.

    public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        Debug.LogError("Cause: " + cause);
    }

    public void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");

        //PhotonNetwork.Instantiate("TestObject", Vector3.zero, Quaternion.identity,0);

        //return;
        PhotonNetwork.Instantiate(headPrefabs.name, ViveManager.Instance.head.transform.position, ViveManager.Instance.head.transform.rotation, 0);
        PhotonNetwork.Instantiate(leftHandPrefabs.name, ViveManager.Instance.leftHand.transform.position, ViveManager.Instance.leftHand.transform.rotation, 0);
        PhotonNetwork.Instantiate(rightHandPrefabs.name, ViveManager.Instance.rightHand.transform.position, ViveManager.Instance.rightHand.transform.rotation, 0);

        if (PhotonNetwork.isMasterClient)
        {
            PhotonNetwork.Instantiate(BuckyBall.name, ItemManager.Instance.BuckyBall.transform.position, ItemManager.Instance.BuckyBall.transform.rotation, 0);

            if (Query_Test.Instance.FP == "1" || Query_Test.Instance.SP == "1" || Query_Test.Instance.TP == "1")
            {
                //store 1
                PhotonNetwork.Instantiate(one_smartphone.name, ItemManager.Instance.one_smartphone.transform.position, ItemManager.Instance.one_smartphone.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_laptop_2.name, ItemManager.Instance.one_laptop_2.transform.position, ItemManager.Instance.one_laptop_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_laptop_1.name, ItemManager.Instance.one_laptop_1.transform.position, ItemManager.Instance.one_laptop_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_laptop.name, ItemManager.Instance.one_laptop.transform.position, ItemManager.Instance.one_laptop.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_PCKeyboard.name, ItemManager.Instance.one_PCKeyboard.transform.position, ItemManager.Instance.one_PCKeyboard.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_Mouse.name, ItemManager.Instance.one_Mouse.transform.position, ItemManager.Instance.one_Mouse.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_tv.name, ItemManager.Instance.one_tv.transform.position, ItemManager.Instance.one_tv.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_speaker.name, ItemManager.Instance.one_speaker.transform.position, ItemManager.Instance.one_speaker.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_pc_speaker.name, ItemManager.Instance.one_pc_speaker.transform.position, ItemManager.Instance.one_pc_speaker.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_pc.name, ItemManager.Instance.one_pc.transform.position, ItemManager.Instance.one_pc.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_notebook.name, ItemManager.Instance.one_notebook.transform.position, ItemManager.Instance.one_notebook.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_mouse.name, ItemManager.Instance.one_mouse.transform.position, ItemManager.Instance.one_mouse.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_monitor.name, ItemManager.Instance.one_monitor.transform.position, ItemManager.Instance.one_monitor.transform.rotation, 0);
                PhotonNetwork.Instantiate(one_keyboard.name, ItemManager.Instance.one_keyboard.transform.position, ItemManager.Instance.one_keyboard.transform.rotation, 0);
            }
            if (Query_Test.Instance.FP == "2" || Query_Test.Instance.SP == "2" || Query_Test.Instance.TP == "2")
            {
                //store 2
                PhotonNetwork.Instantiate(two_PunchingBag_Prefab.name, ItemManager.Instance.two_PunchingBag_Prefab.transform.position, ItemManager.Instance.two_PunchingBag_Prefab.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Paddle_Yellow.name, ItemManager.Instance.two_Paddle_Yellow.transform.position, ItemManager.Instance.two_Paddle_Yellow.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Paddle_Blue.name, ItemManager.Instance.two_Paddle_Blue.transform.position, ItemManager.Instance.two_Paddle_Blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Gloves_Dark.name, ItemManager.Instance.two_Gloves_Dark.transform.position, ItemManager.Instance.two_Gloves_Dark.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Football_White.name, ItemManager.Instance.two_Football_White.transform.position, ItemManager.Instance.two_Football_White.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Basketball_Light.name, ItemManager.Instance.two_Basketball_Light.transform.position, ItemManager.Instance.two_Basketball_Light.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_volleyBallF.name, ItemManager.Instance.two_volleyBallF.transform.position, ItemManager.Instance.two_volleyBallF.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_TableTennisF.name, ItemManager.Instance.two_TableTennisF.transform.position, ItemManager.Instance.two_TableTennisF.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_rugbyF.name, ItemManager.Instance.two_rugbyF.transform.position, ItemManager.Instance.two_rugbyF.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_golfBallF.name, ItemManager.Instance.two_golfBallF.transform.position, ItemManager.Instance.two_golfBallF.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_basketball.name, ItemManager.Instance.two_basketball.transform.position, ItemManager.Instance.two_basketball.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_volleyball_e.name, ItemManager.Instance.two_prop_volleyball_e.transform.position, ItemManager.Instance.two_prop_volleyball_e.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_volleyball_d.name, ItemManager.Instance.two_prop_volleyball_d.transform.position, ItemManager.Instance.two_prop_volleyball_d.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_volleyball_c.name, ItemManager.Instance.two_prop_volleyball_c.transform.position, ItemManager.Instance.two_prop_volleyball_c.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_volleyball_b.name, ItemManager.Instance.two_prop_volleyball_b.transform.position, ItemManager.Instance.two_prop_volleyball_b.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_volleyball_a.name, ItemManager.Instance.two_prop_volleyball_a.transform.position, ItemManager.Instance.two_prop_volleyball_a.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_tennis_ball_a.name, ItemManager.Instance.two_prop_tennis_ball_a.transform.position, ItemManager.Instance.two_prop_tennis_ball_a.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_golf_ball_b.name, ItemManager.Instance.two_prop_golf_ball_b.transform.position, ItemManager.Instance.two_prop_golf_ball_b.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_golf_ball_a.name, ItemManager.Instance.two_prop_golf_ball_a.transform.position, ItemManager.Instance.two_prop_golf_ball_a.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_football_e.name, ItemManager.Instance.two_prop_football_e.transform.position, ItemManager.Instance.two_prop_football_e.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_football_d.name, ItemManager.Instance.two_prop_football_d.transform.position, ItemManager.Instance.two_prop_football_d.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_football_c.name, ItemManager.Instance.two_prop_football_c.transform.position, ItemManager.Instance.two_prop_football_c.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_football_b.name, ItemManager.Instance.two_prop_football_b.transform.position, ItemManager.Instance.two_prop_football_b.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_football_a.name, ItemManager.Instance.two_prop_football_a.transform.position, ItemManager.Instance.two_prop_football_a.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_basketball_e.name, ItemManager.Instance.two_prop_basketball_e.transform.position, ItemManager.Instance.two_prop_basketball_e.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_basketball_d.name, ItemManager.Instance.two_prop_basketball_d.transform.position, ItemManager.Instance.two_prop_basketball_d.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_basketball_c.name, ItemManager.Instance.two_prop_basketball_c.transform.position, ItemManager.Instance.two_prop_basketball_c.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_basketball_b.name, ItemManager.Instance.two_prop_basketball_b.transform.position, ItemManager.Instance.two_prop_basketball_b.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_prop_basketball_a.name, ItemManager.Instance.two_prop_basketball_a.transform.position, ItemManager.Instance.two_prop_basketball_a.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Bodyboard_5.name, ItemManager.Instance.two_Bodyboard_5.transform.position, ItemManager.Instance.two_Bodyboard_5.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Bodyboard_4.name, ItemManager.Instance.two_Bodyboard_4.transform.position, ItemManager.Instance.two_Bodyboard_4.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Bodyboard_3.name, ItemManager.Instance.two_Bodyboard_3.transform.position, ItemManager.Instance.two_Bodyboard_3.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Bodyboard_2.name, ItemManager.Instance.two_Bodyboard_2.transform.position, ItemManager.Instance.two_Bodyboard_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_Bodyboard_1.name, ItemManager.Instance.two_Bodyboard_1.transform.position, ItemManager.Instance.two_Bodyboard_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_BeachBat3.name, ItemManager.Instance.two_BeachBat3.transform.position, ItemManager.Instance.two_BeachBat3.transform.rotation, 0);
                PhotonNetwork.Instantiate(two_BeachBat1.name, ItemManager.Instance.two_BeachBat1.transform.position, ItemManager.Instance.two_BeachBat1.transform.rotation, 0);
            }
            if (Query_Test.Instance.FP == "3" || Query_Test.Instance.SP == "3" || Query_Test.Instance.TP == "3")
            {
                //store 3
                PhotonNetwork.Instantiate(three_Tent_Bag.name, ItemManager.Instance.three_Tent_Bag.transform.position, ItemManager.Instance.three_Tent_Bag.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Survival_Food.name, ItemManager.Instance.three_Survival_Food.transform.position, ItemManager.Instance.three_Survival_Food.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Shovel.name, ItemManager.Instance.three_Shovel.transform.position, ItemManager.Instance.three_Shovel.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_PillBottle.name, ItemManager.Instance.three_PillBottle.transform.position, ItemManager.Instance.three_PillBottle.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Matches_Box.name, ItemManager.Instance.three_Matches_Box.transform.position, ItemManager.Instance.three_Matches_Box.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Knife.name, ItemManager.Instance.three_Knife.transform.position, ItemManager.Instance.three_Knife.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Flask.name, ItemManager.Instance.three_Flask.transform.position, ItemManager.Instance.three_Flask.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Flashlight.name, ItemManager.Instance.three_Flashlight.transform.position, ItemManager.Instance.three_Flashlight.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_DucktTape.name, ItemManager.Instance.three_DucktTape.transform.position, ItemManager.Instance.three_DucktTape.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Compass.name, ItemManager.Instance.three_Compass.transform.position, ItemManager.Instance.three_Compass.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Can_3.name, ItemManager.Instance.three_Can_3.transform.position, ItemManager.Instance.three_Can_3.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Can_2.name, ItemManager.Instance.three_Can_2.transform.position, ItemManager.Instance.three_Can_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Can_1.name, ItemManager.Instance.three_Can_1.transform.position, ItemManager.Instance.three_Can_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Book_2.name, ItemManager.Instance.three_Book_2.transform.position, ItemManager.Instance.three_Book_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Book_1.name, ItemManager.Instance.three_Book_1.transform.position, ItemManager.Instance.three_Book_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Binoculars.name, ItemManager.Instance.three_Binoculars.transform.position, ItemManager.Instance.three_Binoculars.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Battery_2.name, ItemManager.Instance.three_Battery_2.transform.position, ItemManager.Instance.three_Battery_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Battery_1.name, ItemManager.Instance.three_Battery_1.transform.position, ItemManager.Instance.three_Battery_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Axe_Small.name, ItemManager.Instance.three_Axe_Small.transform.position, ItemManager.Instance.three_Axe_Small.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_Axe_Large.name, ItemManager.Instance.three_Axe_Large.transform.position, ItemManager.Instance.three_Axe_Large.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_BoilingPot_Small_BackPacking.name, ItemManager.Instance.three_BoilingPot_Small_BackPacking.transform.position, ItemManager.Instance.three_BoilingPot_Small_BackPacking.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_FryingPan_Small_BackPacking.name, ItemManager.Instance.three_FryingPan_Small_BackPacking.transform.position, ItemManager.Instance.three_FryingPan_Small_BackPacking.transform.rotation, 0);
                PhotonNetwork.Instantiate(three_TeaPot_Backpacking.name, ItemManager.Instance.three_TeaPot_Backpacking.transform.position, ItemManager.Instance.three_TeaPot_Backpacking.transform.rotation, 0);
            }
            if (Query_Test.Instance.FP == "4" || Query_Test.Instance.SP == "4" || Query_Test.Instance.TP == "4")
            {
                //store 4
                PhotonNetwork.Instantiate(four_sledgeHammer.name, ItemManager.Instance.four_sledgeHammer.transform.position, ItemManager.Instance.four_sledgeHammer.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_IceAxe.name, ItemManager.Instance.four_IceAxe.transform.position, ItemManager.Instance.four_IceAxe.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_hammer1.name, ItemManager.Instance.four_hammer1.transform.position, ItemManager.Instance.four_hammer1.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_hacksaw.name, ItemManager.Instance.four_hacksaw.transform.position, ItemManager.Instance.four_hacksaw.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_crowbar1.name, ItemManager.Instance.four_crowbar1.transform.position, ItemManager.Instance.four_crowbar1.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_axe.name, ItemManager.Instance.four_axe.transform.position, ItemManager.Instance.four_axe.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Screwdriver.name, ItemManager.Instance.four_Screwdriver.transform.position, ItemManager.Instance.four_Screwdriver.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Saw.name, ItemManager.Instance.four_Saw.transform.position, ItemManager.Instance.four_Saw.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Hammer.name, ItemManager.Instance.four_Hammer.transform.position, ItemManager.Instance.four_Hammer.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Box.name, ItemManager.Instance.four_Box.transform.position, ItemManager.Instance.four_Box.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Axe.name, ItemManager.Instance.four_Axe.transform.position, ItemManager.Instance.four_Axe.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_spoon.name, ItemManager.Instance.four_spoon.transform.position, ItemManager.Instance.four_spoon.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_soup_plate_high_poly.name, ItemManager.Instance.four_soup_plate_high_poly.transform.position, ItemManager.Instance.four_soup_plate_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_saucer_high_poly.name, ItemManager.Instance.four_saucer_high_poly.transform.position, ItemManager.Instance.four_saucer_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_saucepan_big.name, ItemManager.Instance.four_saucepan_big.transform.position, ItemManager.Instance.four_saucepan_big.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_plate_high_poly.name, ItemManager.Instance.four_plate_high_poly.transform.position, ItemManager.Instance.four_plate_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_pan_high_poly.name, ItemManager.Instance.four_pan_high_poly.transform.position, ItemManager.Instance.four_pan_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_mug_high_poly.name, ItemManager.Instance.four_mug_high_poly.transform.position, ItemManager.Instance.four_mug_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_ladle_high_poly.name, ItemManager.Instance.four_ladle_high_poly.transform.position, ItemManager.Instance.four_ladle_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_knife_big.name, ItemManager.Instance.four_knife_big.transform.position, ItemManager.Instance.four_knife_big.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_fork.name, ItemManager.Instance.four_fork.transform.position, ItemManager.Instance.four_fork.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_PlasticSpoon.name, ItemManager.Instance.four_PlasticSpoon.transform.position, ItemManager.Instance.four_PlasticSpoon.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_cup_high_poly.name, ItemManager.Instance.four_cup_high_poly.transform.position, ItemManager.Instance.four_cup_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_bowl_high_poly.name, ItemManager.Instance.four_bowl_high_poly.transform.position, ItemManager.Instance.four_bowl_high_poly.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_P4_short.name, ItemManager.Instance.four_P4_short.transform.position, ItemManager.Instance.four_P4_short.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_P7_short.name, ItemManager.Instance.four_P7_short.transform.position, ItemManager.Instance.four_P7_short.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_P6_short.name, ItemManager.Instance.four_P6_short.transform.position, ItemManager.Instance.four_P6_short.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_P5_short.name, ItemManager.Instance.four_P5_short.transform.position, ItemManager.Instance.four_P5_short.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_P3_short.name, ItemManager.Instance.four_P3_short.transform.position, ItemManager.Instance.four_P3_short.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_P1_short.name, ItemManager.Instance.four_P1_short.transform.position, ItemManager.Instance.four_P1_short.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Long_4.name, ItemManager.Instance.four_Long_4.transform.position, ItemManager.Instance.four_Long_4.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Long_2.name, ItemManager.Instance.four_Long_2.transform.position, ItemManager.Instance.four_Long_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_Long_1.name, ItemManager.Instance.four_Long_1.transform.position, ItemManager.Instance.four_Long_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_watering_can_red.name, ItemManager.Instance.four_watering_can_red.transform.position, ItemManager.Instance.four_watering_can_red.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_watering_can_green.name, ItemManager.Instance.four_watering_can_green.transform.position, ItemManager.Instance.four_watering_can_green.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_watering_can_blue.name, ItemManager.Instance.four_watering_can_blue.transform.position, ItemManager.Instance.four_watering_can_blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_wheel_barrow_blue.name, ItemManager.Instance.four_wheel_barrow_blue.transform.position, ItemManager.Instance.four_wheel_barrow_blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_watering_can.name, ItemManager.Instance.four_watering_can.transform.position, ItemManager.Instance.four_watering_can.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_spanner.name, ItemManager.Instance.four_spanner.transform.position, ItemManager.Instance.four_spanner.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_PlasticSpork.name, ItemManager.Instance.four_PlasticSpork.transform.position, ItemManager.Instance.four_PlasticSpork.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_rake.name, ItemManager.Instance.four_rake.transform.position, ItemManager.Instance.four_rake.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_prong.name, ItemManager.Instance.four_prong.transform.position, ItemManager.Instance.four_prong.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_TableFork.name, ItemManager.Instance.four_TableFork.transform.position, ItemManager.Instance.four_TableFork.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_TableSppon.name, ItemManager.Instance.four_TableSppon.transform.position, ItemManager.Instance.four_TableSppon.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_WoodCoffeeTable.name, ItemManager.Instance.four_WoodCoffeeTable.transform.position, ItemManager.Instance.four_WoodCoffeeTable.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_MetalStool.name, ItemManager.Instance.four_MetalStool.transform.position, ItemManager.Instance.four_MetalStool.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_plunger.name, ItemManager.Instance.four_plunger.transform.position, ItemManager.Instance.four_plunger.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_cylinder_brush_blue.name, ItemManager.Instance.four_cylinder_brush_blue.transform.position, ItemManager.Instance.four_cylinder_brush_blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_crowbar.name, ItemManager.Instance.four_crowbar.transform.position, ItemManager.Instance.four_crowbar.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_chisel.name, ItemManager.Instance.four_chisel.transform.position, ItemManager.Instance.four_chisel.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_bucket.name, ItemManager.Instance.four_bucket.transform.position, ItemManager.Instance.four_bucket.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_broom.name, ItemManager.Instance.four_broom.transform.position, ItemManager.Instance.four_broom.transform.rotation, 0);
                PhotonNetwork.Instantiate(four_WoodedCoffeeTable2.name, ItemManager.Instance.four_WoodedCoffeeTable2.transform.position, ItemManager.Instance.four_WoodedCoffeeTable2.transform.rotation, 0);
            }
            if (Query_Test.Instance.FP == "5" || Query_Test.Instance.SP == "5" || Query_Test.Instance.TP == "5")
            {
                //store 5
                PhotonNetwork.Instantiate(five_RoundCut.name, ItemManager.Instance.five_RoundCut.transform.position, ItemManager.Instance.five_RoundCut.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_RoseCut.name, ItemManager.Instance.five_RoseCut.transform.position, ItemManager.Instance.five_RoseCut.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_PearCut.name, ItemManager.Instance.five_PearCut.transform.position, ItemManager.Instance.five_PearCut.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_OldSingleCut.name, ItemManager.Instance.five_OldSingleCut.transform.position, ItemManager.Instance.five_OldSingleCut.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_school_bag_3.name, ItemManager.Instance.five_school_bag_3.transform.position, ItemManager.Instance.five_school_bag_3.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_school_bag_2.name, ItemManager.Instance.five_school_bag_2.transform.position, ItemManager.Instance.five_school_bag_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_school_bag_1.name, ItemManager.Instance.five_school_bag_1.transform.position, ItemManager.Instance.five_school_bag_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_backpack_3.name, ItemManager.Instance.five_backpack_3.transform.position, ItemManager.Instance.five_backpack_3.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_backpack_2.name, ItemManager.Instance.five_backpack_2.transform.position, ItemManager.Instance.five_backpack_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_backpack_1.name, ItemManager.Instance.five_backpack_1.transform.position, ItemManager.Instance.five_backpack_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object038.name, ItemManager.Instance.five_Object038.transform.position, ItemManager.Instance.five_Object038.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object036.name, ItemManager.Instance.five_Object036.transform.position, ItemManager.Instance.five_Object036.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object034.name, ItemManager.Instance.five_Object034.transform.position, ItemManager.Instance.five_Object034.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object032.name, ItemManager.Instance.five_Object032.transform.position, ItemManager.Instance.five_Object032.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object030.name, ItemManager.Instance.five_Object030.transform.position, ItemManager.Instance.five_Object030.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object024.name, ItemManager.Instance.five_Object024.transform.position, ItemManager.Instance.five_Object024.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object022.name, ItemManager.Instance.five_Object022.transform.position, ItemManager.Instance.five_Object022.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object016.name, ItemManager.Instance.five_Object016.transform.position, ItemManager.Instance.five_Object016.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object14.name, ItemManager.Instance.five_Object14.transform.position, ItemManager.Instance.five_Object14.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object026.name, ItemManager.Instance.five_Object026.transform.position, ItemManager.Instance.five_Object026.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object020.name, ItemManager.Instance.five_Object020.transform.position, ItemManager.Instance.five_Object020.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object018.name, ItemManager.Instance.five_Object018.transform.position, ItemManager.Instance.five_Object018.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object15.name, ItemManager.Instance.five_Object15.transform.position, ItemManager.Instance.five_Object15.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object010.name, ItemManager.Instance.five_Object010.transform.position, ItemManager.Instance.five_Object010.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object008.name, ItemManager.Instance.five_Object008.transform.position, ItemManager.Instance.five_Object008.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object006.name, ItemManager.Instance.five_Object006.transform.position, ItemManager.Instance.five_Object006.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object004.name, ItemManager.Instance.five_Object004.transform.position, ItemManager.Instance.five_Object004.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object99.name, ItemManager.Instance.five_Object99.transform.position, ItemManager.Instance.five_Object99.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object98.name, ItemManager.Instance.five_Object98.transform.position, ItemManager.Instance.five_Object98.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Cylinder03.name, ItemManager.Instance.five_Cylinder03.transform.position, ItemManager.Instance.five_Cylinder03.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line32.name, ItemManager.Instance.five_Line32.transform.position, ItemManager.Instance.five_Line32.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line30.name, ItemManager.Instance.five_Line30.transform.position, ItemManager.Instance.five_Line30.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line28.name, ItemManager.Instance.five_Line28.transform.position, ItemManager.Instance.five_Line28.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line26.name, ItemManager.Instance.five_Line26.transform.position, ItemManager.Instance.five_Line26.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line24.name, ItemManager.Instance.five_Line24.transform.position, ItemManager.Instance.five_Line24.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line22.name, ItemManager.Instance.five_Line22.transform.position, ItemManager.Instance.five_Line22.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line20.name, ItemManager.Instance.five_Line20.transform.position, ItemManager.Instance.five_Line20.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line18.name, ItemManager.Instance.five_Line18.transform.position, ItemManager.Instance.five_Line18.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line17.name, ItemManager.Instance.five_Line17.transform.position, ItemManager.Instance.five_Line17.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line16.name, ItemManager.Instance.five_Line16.transform.position, ItemManager.Instance.five_Line16.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line15.name, ItemManager.Instance.five_Line15.transform.position, ItemManager.Instance.five_Line15.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object003_2.name, ItemManager.Instance.five_Object003_2.transform.position, ItemManager.Instance.five_Object003_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object003_1.name, ItemManager.Instance.five_Object003_1.transform.position, ItemManager.Instance.five_Object003_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object003.name, ItemManager.Instance.five_Object003.transform.position, ItemManager.Instance.five_Object003.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object002_3.name, ItemManager.Instance.five_Object002_3.transform.position, ItemManager.Instance.five_Object002_3.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object002_2.name, ItemManager.Instance.five_Object002_2.transform.position, ItemManager.Instance.five_Object002_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object002.name, ItemManager.Instance.five_Object002.transform.position, ItemManager.Instance.five_Object002.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Object001_2.name, ItemManager.Instance.five_Object001_2.transform.position, ItemManager.Instance.five_Object001_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line02_1.name, ItemManager.Instance.five_Line02_1.transform.position, ItemManager.Instance.five_Line02_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_Line02.name, ItemManager.Instance.five_Line02.transform.position, ItemManager.Instance.five_Line02.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_suitcase11.name, ItemManager.Instance.five_suitcase11.transform.position, ItemManager.Instance.five_suitcase11.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_suitcase9.name, ItemManager.Instance.five_suitcase9.transform.position, ItemManager.Instance.five_suitcase9.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_suitcase8.name, ItemManager.Instance.five_suitcase8.transform.position, ItemManager.Instance.five_suitcase8.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_suitcase6.name, ItemManager.Instance.five_suitcase6.transform.position, ItemManager.Instance.five_suitcase6.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_suitcase5.name, ItemManager.Instance.five_suitcase5.transform.position, ItemManager.Instance.five_suitcase5.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase13.name, ItemManager.Instance.five_briefcase13.transform.position, ItemManager.Instance.five_briefcase13.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase12.name, ItemManager.Instance.five_briefcase12.transform.position, ItemManager.Instance.five_briefcase12.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase11.name, ItemManager.Instance.five_briefcase11.transform.position, ItemManager.Instance.five_briefcase11.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase10.name, ItemManager.Instance.five_briefcase10.transform.position, ItemManager.Instance.five_briefcase10.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase7.name, ItemManager.Instance.five_briefcase7.transform.position, ItemManager.Instance.five_briefcase7.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase6.name, ItemManager.Instance.five_briefcase6.transform.position, ItemManager.Instance.five_briefcase6.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase5.name, ItemManager.Instance.five_briefcase5.transform.position, ItemManager.Instance.five_briefcase5.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_briefcase3.name, ItemManager.Instance.five_briefcase3.transform.position, ItemManager.Instance.five_briefcase3.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag24.name, ItemManager.Instance.five_bag24.transform.position, ItemManager.Instance.five_bag24.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag23.name, ItemManager.Instance.five_bag23.transform.position, ItemManager.Instance.five_bag23.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag22.name, ItemManager.Instance.five_bag22.transform.position, ItemManager.Instance.five_bag22.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag21.name, ItemManager.Instance.five_bag21.transform.position, ItemManager.Instance.five_bag21.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag20.name, ItemManager.Instance.five_bag20.transform.position, ItemManager.Instance.five_bag20.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag19.name, ItemManager.Instance.five_bag19.transform.position, ItemManager.Instance.five_bag19.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag18.name, ItemManager.Instance.five_bag18.transform.position, ItemManager.Instance.five_bag18.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag17.name, ItemManager.Instance.five_bag17.transform.position, ItemManager.Instance.five_bag17.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag16.name, ItemManager.Instance.five_bag16.transform.position, ItemManager.Instance.five_bag16.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag15.name, ItemManager.Instance.five_bag15.transform.position, ItemManager.Instance.five_bag15.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag12.name, ItemManager.Instance.five_bag12.transform.position, ItemManager.Instance.five_bag12.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag11.name, ItemManager.Instance.five_bag11.transform.position, ItemManager.Instance.five_bag11.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag10.name, ItemManager.Instance.five_bag10.transform.position, ItemManager.Instance.five_bag10.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag9.name, ItemManager.Instance.five_bag9.transform.position, ItemManager.Instance.five_bag9.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag8.name, ItemManager.Instance.five_bag8.transform.position, ItemManager.Instance.five_bag8.transform.rotation, 0);
                PhotonNetwork.Instantiate(five_bag4.name, ItemManager.Instance.five_bag4.transform.position, ItemManager.Instance.five_bag4.transform.rotation, 0);
            }
            if (Query_Test.Instance.FP == "6" || Query_Test.Instance.SP == "6" || Query_Test.Instance.TP == "6")
            {
                //store6
                PhotonNetwork.Instantiate(six_TShirt_Hanging_White_Unity.name, ItemManager.Instance.six_TShirt_Hanging_White_Unity.transform.position, ItemManager.Instance.six_TShirt_Hanging_White_Unity.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Hanging_Yellow.name, ItemManager.Instance.six_TShirt_Hanging_Yellow.transform.position, ItemManager.Instance.six_TShirt_Hanging_Yellow.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Hanging_RivermillStudios.name, ItemManager.Instance.six_TShirt_Hanging_RivermillStudios.transform.position, ItemManager.Instance.six_TShirt_Hanging_RivermillStudios.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Hanging_Red.name, ItemManager.Instance.six_TShirt_Hanging_Red.transform.position, ItemManager.Instance.six_TShirt_Hanging_Red.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Hanging_Green.name, ItemManager.Instance.six_TShirt_Hanging_Green.transform.position, ItemManager.Instance.six_TShirt_Hanging_Green.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Hanging_Blue.name, ItemManager.Instance.six_TShirt_Hanging_Blue.transform.position, ItemManager.Instance.six_TShirt_Hanging_Blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Hanging_Black_Unity.name, ItemManager.Instance.six_TShirt_Hanging_Black_Unity.transform.position, ItemManager.Instance.six_TShirt_Hanging_Black_Unity.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Folded_Yellow.name, ItemManager.Instance.six_TShirt_Folded_Yellow.transform.position, ItemManager.Instance.six_TShirt_Folded_Yellow.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Folded_Unity_White.name, ItemManager.Instance.six_TShirt_Folded_Unity_White.transform.position, ItemManager.Instance.six_TShirt_Folded_Unity_White.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Folded_Unity_Black.name, ItemManager.Instance.six_TShirt_Folded_Unity_Black.transform.position, ItemManager.Instance.six_TShirt_Folded_Unity_Black.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Folded_RivermillStudios.name, ItemManager.Instance.six_TShirt_Folded_RivermillStudios.transform.position, ItemManager.Instance.six_TShirt_Folded_RivermillStudios.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Folded_Red.name, ItemManager.Instance.six_TShirt_Folded_Red.transform.position, ItemManager.Instance.six_TShirt_Folded_Red.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Folded_Pink.name, ItemManager.Instance.six_TShirt_Folded_Pink.transform.position, ItemManager.Instance.six_TShirt_Folded_Pink.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_TShirt_Folded_Blue.name, ItemManager.Instance.six_TShirt_Folded_Blue.transform.position, ItemManager.Instance.six_TShirt_Folded_Blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Trainers_white.name, ItemManager.Instance.six_Trainers_white.transform.position, ItemManager.Instance.six_Trainers_white.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Trainers_Green.name, ItemManager.Instance.six_Trainers_Green.transform.position, ItemManager.Instance.six_Trainers_Green.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Trainers_Blue.name, ItemManager.Instance.six_Trainers_Blue.transform.position, ItemManager.Instance.six_Trainers_Blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Trainers_Black.name, ItemManager.Instance.six_Trainers_Black.transform.position, ItemManager.Instance.six_Trainers_Black.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Jeans_Black.name, ItemManager.Instance.six_Jeans_Black.transform.position, ItemManager.Instance.six_Jeans_Black.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Jacket.name, ItemManager.Instance.six_Jacket.transform.position, ItemManager.Instance.six_Jacket.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Hat_Yellow.name, ItemManager.Instance.six_Hat_Yellow.transform.position, ItemManager.Instance.six_Hat_Yellow.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Hat_White.name, ItemManager.Instance.six_Hat_White.transform.position, ItemManager.Instance.six_Hat_White.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Hat_Brown.name, ItemManager.Instance.six_Hat_Brown.transform.position, ItemManager.Instance.six_Hat_Brown.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Hat_Blue.name, ItemManager.Instance.six_Hat_Blue.transform.position, ItemManager.Instance.six_Hat_Blue.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_Hat_Black.name, ItemManager.Instance.six_Hat_Black.transform.position, ItemManager.Instance.six_Hat_Black.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe8.name, ItemManager.Instance.six_mens_shoe8.transform.position, ItemManager.Instance.six_mens_shoe8.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe7.name, ItemManager.Instance.six_mens_shoe7.transform.position, ItemManager.Instance.six_mens_shoe7.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe6.name, ItemManager.Instance.six_mens_shoe6.transform.position, ItemManager.Instance.six_mens_shoe6.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe5.name, ItemManager.Instance.six_mens_shoe5.transform.position, ItemManager.Instance.six_mens_shoe5.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe4.name, ItemManager.Instance.six_mens_shoe4.transform.position, ItemManager.Instance.six_mens_shoe4.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe3.name, ItemManager.Instance.six_mens_shoe3.transform.position, ItemManager.Instance.six_mens_shoe3.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe2.name, ItemManager.Instance.six_mens_shoe2.transform.position, ItemManager.Instance.six_mens_shoe2.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_mens_shoe1.name, ItemManager.Instance.six_mens_shoe1.transform.position, ItemManager.Instance.six_mens_shoe1.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe16.name, ItemManager.Instance.six_lady_shoe16.transform.position, ItemManager.Instance.six_lady_shoe16.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe15.name, ItemManager.Instance.six_lady_shoe15.transform.position, ItemManager.Instance.six_lady_shoe15.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe14.name, ItemManager.Instance.six_lady_shoe14.transform.position, ItemManager.Instance.six_lady_shoe14.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe13.name, ItemManager.Instance.six_lady_shoe13.transform.position, ItemManager.Instance.six_lady_shoe13.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe12.name, ItemManager.Instance.six_lady_shoe12.transform.position, ItemManager.Instance.six_lady_shoe12.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe11.name, ItemManager.Instance.six_lady_shoe11.transform.position, ItemManager.Instance.six_lady_shoe11.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe10.name, ItemManager.Instance.six_lady_shoe10.transform.position, ItemManager.Instance.six_lady_shoe10.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe9.name, ItemManager.Instance.six_lady_shoe9.transform.position, ItemManager.Instance.six_lady_shoe9.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe8.name, ItemManager.Instance.six_lady_shoe8.transform.position, ItemManager.Instance.six_lady_shoe8.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe7.name, ItemManager.Instance.six_lady_shoe7.transform.position, ItemManager.Instance.six_lady_shoe7.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe6.name, ItemManager.Instance.six_lady_shoe6.transform.position, ItemManager.Instance.six_lady_shoe6.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe5.name, ItemManager.Instance.six_lady_shoe5.transform.position, ItemManager.Instance.six_lady_shoe5.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe4.name, ItemManager.Instance.six_lady_shoe4.transform.position, ItemManager.Instance.six_lady_shoe4.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe3.name, ItemManager.Instance.six_lady_shoe3.transform.position, ItemManager.Instance.six_lady_shoe3.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe2.name, ItemManager.Instance.six_lady_shoe2.transform.position, ItemManager.Instance.six_lady_shoe2.transform.rotation, 0);
                PhotonNetwork.Instantiate(six_lady_shoe1.name, ItemManager.Instance.six_lady_shoe1.transform.position, ItemManager.Instance.six_lady_shoe1.transform.rotation, 0);
            }
            if (Query_Test.Instance.FP == "7" || Query_Test.Instance.SP == "7" || Query_Test.Instance.TP == "7")
            {
                //store7
                PhotonNetwork.Instantiate(seven_Strawberry.name, ItemManager.Instance.seven_Strawberry.transform.position, ItemManager.Instance.seven_Strawberry.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Pear.name, ItemManager.Instance.seven_Pear.transform.position, ItemManager.Instance.seven_Pear.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Kiwi.name, ItemManager.Instance.seven_Kiwi.transform.position, ItemManager.Instance.seven_Kiwi.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Banana.name, ItemManager.Instance.seven_Banana.transform.position, ItemManager.Instance.seven_Banana.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Apple1.name, ItemManager.Instance.seven_Apple1.transform.position, ItemManager.Instance.seven_Apple1.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can_3.name, ItemManager.Instance.seven_Can_3.transform.position, ItemManager.Instance.seven_Can_3.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can_2.name, ItemManager.Instance.seven_Can_2.transform.position, ItemManager.Instance.seven_Can_2.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can_1.name, ItemManager.Instance.seven_Can_1.transform.position, ItemManager.Instance.seven_Can_1.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_tuna.name, ItemManager.Instance.seven_tuna.transform.position, ItemManager.Instance.seven_tuna.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_squid.name, ItemManager.Instance.seven_squid.transform.position, ItemManager.Instance.seven_squid.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_soup.name, ItemManager.Instance.seven_soup.transform.position, ItemManager.Instance.seven_soup.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_milk.name, ItemManager.Instance.seven_milk.transform.position, ItemManager.Instance.seven_milk.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_jar.name, ItemManager.Instance.seven_jar.transform.position, ItemManager.Instance.seven_jar.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_corn.name, ItemManager.Instance.seven_corn.transform.position, ItemManager.Instance.seven_corn.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_chips.name, ItemManager.Instance.seven_chips.transform.position, ItemManager.Instance.seven_chips.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_cornbox.name, ItemManager.Instance.seven_cornbox.transform.position, ItemManager.Instance.seven_cornbox.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_WaterMElon.name, ItemManager.Instance.seven_WaterMElon.transform.position, ItemManager.Instance.seven_WaterMElon.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Sauce1.name, ItemManager.Instance.seven_Sauce1.transform.position, ItemManager.Instance.seven_Sauce1.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_RollingPin.name, ItemManager.Instance.seven_RollingPin.transform.position, ItemManager.Instance.seven_RollingPin.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Milk.name, ItemManager.Instance.seven_Milk.transform.position, ItemManager.Instance.seven_Milk.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Lemon.name, ItemManager.Instance.seven_Lemon.transform.position, ItemManager.Instance.seven_Lemon.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_deeppan.name, ItemManager.Instance.seven_deeppan.transform.position, ItemManager.Instance.seven_deeppan.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_CornFlakes.name, ItemManager.Instance.seven_CornFlakes.transform.position, ItemManager.Instance.seven_CornFlakes.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Board.name, ItemManager.Instance.seven_Board.transform.position, ItemManager.Instance.seven_Board.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Apple.name, ItemManager.Instance.seven_Apple.transform.position, ItemManager.Instance.seven_Apple.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can4.name, ItemManager.Instance.seven_Can4.transform.position, ItemManager.Instance.seven_Can4.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can3.name, ItemManager.Instance.seven_Can3.transform.position, ItemManager.Instance.seven_Can3.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can2.name, ItemManager.Instance.seven_Can2.transform.position, ItemManager.Instance.seven_Can2.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can1.name, ItemManager.Instance.seven_Can1.transform.position, ItemManager.Instance.seven_Can1.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Can.name, ItemManager.Instance.seven_Can.transform.position, ItemManager.Instance.seven_Can.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Bottle4.name, ItemManager.Instance.seven_Bottle4.transform.position, ItemManager.Instance.seven_Bottle4.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Bottle3.name, ItemManager.Instance.seven_Bottle3.transform.position, ItemManager.Instance.seven_Bottle3.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Bottle2.name, ItemManager.Instance.seven_Bottle2.transform.position, ItemManager.Instance.seven_Bottle2.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Bottle1.name, ItemManager.Instance.seven_Bottle1.transform.position, ItemManager.Instance.seven_Bottle1.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_Bottle.name, ItemManager.Instance.seven_Bottle.transform.position, ItemManager.Instance.seven_Bottle.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_croissant_03_mid.name, ItemManager.Instance.seven_croissant_03_mid.transform.position, ItemManager.Instance.seven_croissant_03_mid.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_croissant_03_low.name, ItemManager.Instance.seven_croissant_03_low.transform.position, ItemManager.Instance.seven_croissant_03_low.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_croissant_02_mid.name, ItemManager.Instance.seven_croissant_02_mid.transform.position, ItemManager.Instance.seven_croissant_02_mid.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_croissant_02_low.name, ItemManager.Instance.seven_croissant_02_low.transform.position, ItemManager.Instance.seven_croissant_02_low.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_croissant_01_mid.name, ItemManager.Instance.seven_croissant_01_mid.transform.position, ItemManager.Instance.seven_croissant_01_mid.transform.rotation, 0);
                PhotonNetwork.Instantiate(seven_croissant_01_low.name, ItemManager.Instance.seven_croissant_01_low.transform.position, ItemManager.Instance.seven_croissant_01_low.transform.rotation, 0);
            }
            if (Query_Test.Instance.FP == "8" || Query_Test.Instance.SP == "8" || Query_Test.Instance.TP == "8")
            {
                //store 8
                PhotonNetwork.Instantiate(eight_Tricycle.name, ItemManager.Instance.eight_Tricycle.transform.position, ItemManager.Instance.eight_Tricycle.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_TrainCart2.name, ItemManager.Instance.eight_TrainCart2.transform.position, ItemManager.Instance.eight_TrainCart2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_TrainCart1.name, ItemManager.Instance.eight_TrainCart1.transform.position, ItemManager.Instance.eight_TrainCart1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Train.name, ItemManager.Instance.eight_Train.transform.position, ItemManager.Instance.eight_Train.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Rocket.name, ItemManager.Instance.eight_Rocket.transform.position, ItemManager.Instance.eight_Rocket.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Mouse.name, ItemManager.Instance.eight_Mouse.transform.position, ItemManager.Instance.eight_Mouse.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Horse.name, ItemManager.Instance.eight_Horse.transform.position, ItemManager.Instance.eight_Horse.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Duck.name, ItemManager.Instance.eight_Duck.transform.position, ItemManager.Instance.eight_Duck.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Car.name, ItemManager.Instance.eight_Car.transform.position, ItemManager.Instance.eight_Car.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Ball.name, ItemManager.Instance.eight_Ball.transform.position, ItemManager.Instance.eight_Ball.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Airplane.name, ItemManager.Instance.eight_Airplane.transform.position, ItemManager.Instance.eight_Airplane.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_xylophone2.name, ItemManager.Instance.eight_xylophone2.transform.position, ItemManager.Instance.eight_xylophone2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_xylophone1.name, ItemManager.Instance.eight_xylophone1.transform.position, ItemManager.Instance.eight_xylophone1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_rhythmegg5.name, ItemManager.Instance.eight_rhythmegg5.transform.position, ItemManager.Instance.eight_rhythmegg5.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_rhythmegg4.name, ItemManager.Instance.eight_rhythmegg4.transform.position, ItemManager.Instance.eight_rhythmegg4.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_rhythmegg3.name, ItemManager.Instance.eight_rhythmegg3.transform.position, ItemManager.Instance.eight_rhythmegg3.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_rhythmegg2.name, ItemManager.Instance.eight_rhythmegg2.transform.position, ItemManager.Instance.eight_rhythmegg2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_rhythmegg1.name, ItemManager.Instance.eight_rhythmegg1.transform.position, ItemManager.Instance.eight_rhythmegg1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_piano7.name, ItemManager.Instance.eight_piano7.transform.position, ItemManager.Instance.eight_piano7.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_piano6.name, ItemManager.Instance.eight_piano6.transform.position, ItemManager.Instance.eight_piano6.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_piano5.name, ItemManager.Instance.eight_piano5.transform.position, ItemManager.Instance.eight_piano5.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_piano4.name, ItemManager.Instance.eight_piano4.transform.position, ItemManager.Instance.eight_piano4.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_piano3.name, ItemManager.Instance.eight_piano3.transform.position, ItemManager.Instance.eight_piano3.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_piano2.name, ItemManager.Instance.eight_piano2.transform.position, ItemManager.Instance.eight_piano2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_piano1.name, ItemManager.Instance.eight_piano1.transform.position, ItemManager.Instance.eight_piano1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_maracas6.name, ItemManager.Instance.eight_maracas6.transform.position, ItemManager.Instance.eight_maracas6.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_maracas5.name, ItemManager.Instance.eight_maracas5.transform.position, ItemManager.Instance.eight_maracas5.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_maracas4.name, ItemManager.Instance.eight_maracas4.transform.position, ItemManager.Instance.eight_maracas4.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_maracas3.name, ItemManager.Instance.eight_maracas3.transform.position, ItemManager.Instance.eight_maracas3.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_maracas2.name, ItemManager.Instance.eight_maracas2.transform.position, ItemManager.Instance.eight_maracas2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_maracas1.name, ItemManager.Instance.eight_maracas1.transform.position, ItemManager.Instance.eight_maracas1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_harmonica7.name, ItemManager.Instance.eight_harmonica7.transform.position, ItemManager.Instance.eight_harmonica7.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_harmonica6.name, ItemManager.Instance.eight_harmonica6.transform.position, ItemManager.Instance.eight_harmonica6.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_harmonica5.name, ItemManager.Instance.eight_harmonica5.transform.position, ItemManager.Instance.eight_harmonica5.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_harmonica4.name, ItemManager.Instance.eight_harmonica4.transform.position, ItemManager.Instance.eight_harmonica4.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_harmonica3.name, ItemManager.Instance.eight_harmonica3.transform.position, ItemManager.Instance.eight_harmonica3.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_harmonica2.name, ItemManager.Instance.eight_harmonica2.transform.position, ItemManager.Instance.eight_harmonica2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_harmonica1.name, ItemManager.Instance.eight_harmonica1.transform.position, ItemManager.Instance.eight_harmonica1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute8.name, ItemManager.Instance.eight_flute8.transform.position, ItemManager.Instance.eight_flute8.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute7.name, ItemManager.Instance.eight_flute7.transform.position, ItemManager.Instance.eight_flute7.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute6.name, ItemManager.Instance.eight_flute6.transform.position, ItemManager.Instance.eight_flute6.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute5.name, ItemManager.Instance.eight_flute5.transform.position, ItemManager.Instance.eight_flute5.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute4.name, ItemManager.Instance.eight_flute4.transform.position, ItemManager.Instance.eight_flute4.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute3.name, ItemManager.Instance.eight_flute3.transform.position, ItemManager.Instance.eight_flute3.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute2.name, ItemManager.Instance.eight_flute2.transform.position, ItemManager.Instance.eight_flute2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_flute1.name, ItemManager.Instance.eight_flute1.transform.position, ItemManager.Instance.eight_flute1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_drumandstick6.name, ItemManager.Instance.eight_drumandstick6.transform.position, ItemManager.Instance.eight_drumandstick6.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_drumandstick5.name, ItemManager.Instance.eight_drumandstick5.transform.position, ItemManager.Instance.eight_drumandstick5.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_drumandstick4.name, ItemManager.Instance.eight_drumandstick4.transform.position, ItemManager.Instance.eight_drumandstick4.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_drumandstick3.name, ItemManager.Instance.eight_drumandstick3.transform.position, ItemManager.Instance.eight_drumandstick3.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_drumandstick2.name, ItemManager.Instance.eight_drumandstick2.transform.position, ItemManager.Instance.eight_drumandstick2.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_drumandstick1.name, ItemManager.Instance.eight_drumandstick1.transform.position, ItemManager.Instance.eight_drumandstick1.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Toy_Snowman.name, ItemManager.Instance.eight_Toy_Snowman.transform.position, ItemManager.Instance.eight_Toy_Snowman.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Toy_Bell.name, ItemManager.Instance.eight_Toy_Bell.transform.position, ItemManager.Instance.eight_Toy_Bell.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Toy_Ball.name, ItemManager.Instance.eight_Toy_Ball.transform.position, ItemManager.Instance.eight_Toy_Ball.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_GiftBox_Square_TypeB.name, ItemManager.Instance.eight_GiftBox_Square_TypeB.transform.position, ItemManager.Instance.eight_GiftBox_Square_TypeB.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_GiftBox_Square_TypeA.name, ItemManager.Instance.eight_GiftBox_Square_TypeA.transform.position, ItemManager.Instance.eight_GiftBox_Square_TypeA.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_GiftBox_Rectangle_TypeB.name, ItemManager.Instance.eight_GiftBox_Rectangle_TypeB.transform.position, ItemManager.Instance.eight_GiftBox_Rectangle_TypeB.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_GiftBox_Rectangle_TypeA.name, ItemManager.Instance.eight_GiftBox_Rectangle_TypeA.transform.position, ItemManager.Instance.eight_GiftBox_Rectangle_TypeA.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_GiftBox_Cylinder_TypeB.name, ItemManager.Instance.eight_GiftBox_Cylinder_TypeB.transform.position, ItemManager.Instance.eight_GiftBox_Cylinder_TypeB.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_GiftBox_Cylinder_TypeA.name, ItemManager.Instance.eight_GiftBox_Cylinder_TypeA.transform.position, ItemManager.Instance.eight_GiftBox_Cylinder_TypeA.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_ChristmasSock.name, ItemManager.Instance.eight_ChristmasSock.transform.position, ItemManager.Instance.eight_ChristmasSock.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_CandyCaneWithBow.name, ItemManager.Instance.eight_CandyCaneWithBow.transform.position, ItemManager.Instance.eight_CandyCaneWithBow.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Candy.name, ItemManager.Instance.eight_Candy.transform.position, ItemManager.Instance.eight_Candy.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Candle_Small.name, ItemManager.Instance.eight_Candle_Small.transform.position, ItemManager.Instance.eight_Candle_Small.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_BabyStroller04.name, ItemManager.Instance.eight_BabyStroller04.transform.position, ItemManager.Instance.eight_BabyStroller04.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Train_toy.name, ItemManager.Instance.eight_Train_toy.transform.position, ItemManager.Instance.eight_Train_toy.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Tank_toy.name, ItemManager.Instance.eight_Tank_toy.transform.position, ItemManager.Instance.eight_Tank_toy.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Ship_toy.name, ItemManager.Instance.eight_Ship_toy.transform.position, ItemManager.Instance.eight_Ship_toy.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Helicopter_toy.name, ItemManager.Instance.eight_Helicopter_toy.transform.position, ItemManager.Instance.eight_Helicopter_toy.transform.rotation, 0);
                PhotonNetwork.Instantiate(eight_Duck_toy.name, ItemManager.Instance.eight_Duck_toy.transform.position, ItemManager.Instance.eight_Duck_toy.transform.rotation, 0);
            }

            //PhotonNetwork.Instantiate(9999999999999999.name, ItemManager.Instance..9999999999999999999.transform.position, ItemManager.Instance..9999999999999999999.transform.rotation, 0);

        }
    }
}
