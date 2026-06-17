# Highway Harverst - A Unity Game Development Challange

> A 3D driving game built in Unity where you navigate a farm jeep through a village route, collecting fruits while avoiding rocks, bears and wolves.

![Unity](https://img.shields.io/badge/Unity-6000.2.7f2-green)
![License](https://img.shields.io/badge/License-MIT-red)
![Platform](https://img.shields.io/badge/Platform-Windows-blue)
![Render](https://img.shields.io/badge/Pipeline-URP-orange)

---

## What is this ?

Heighway Harverst is a Unity  3D game where the player drives a pickup jeep through a scenic village environment, collecting fruits scattered along the road and the jungle. The environment features realistic terrain, winding roads with  railings, trees, grass, rocs, hourses, and animated wildlife - all build using Unity's Universal Render Pipeline (URP).

---

## Demo

```
🛻 Drive the farm deep down the village route
🍓 Collect apples, bananas, wartermelons, and  strawberries
🐻 Aviod rocks, bears and Wolves on the road
🏁 Reach the destination with alteast 200 fuits with at least 35 strawberries to complete the level
```

![image](images/image1.png)

![image](images/image2.png)

![image](images/image3.png)

![image](images/image4.png)

![image](images/image5.png)

---

## Features

- 🛻**Vehicle Physics** - realistic jeep with Wheel Coliders and custom car controller script
- 📷**Thired-person camera** - Cinemachine FreeLook camera that avoids obstacles 
- 🛣 **Road system** - winding village roads with railings built using Road Architect 
- 🌳**Rich environment** - terrain with grass, flowers, conifer trees, and country houses 
- 🐻**Animated wildlife** - bears and wolves placed along the route 
- 🍓**Collectible fruits** - apples, bananas, watermelons, and strawberries with rigger colliders
- 🧮**Score UI** - on-screen fruit count with icons for each fruit type 
- ⚙️**Modular scripts** - separate scripts for fruit logic, vehicle inverntory and UI display 

---

## Requirements

- Unity Editior version **6000.2.7f2**
- Visual Studio with **"Game Developments with Unity"** workload
- Windows OS

---

## Installaction


### 1. Clone the repository

```bash
git clone https://github.com/Chamika-Dilshan-Anuruddha/Highway-Harvest.git
```
### 2. Open in Unity Hub

- Open **Unity Hub**
- Click  **Open** -> select the cloned project folder
- Make sure Editor version **6000.2.7f2** is installed


### 3. Set up Visual Studio as the script editor

```
Edit -> Preferences -> External Tools -> External Script Editor -> Visual Studio
```

### 4. Fix Active Input Handling (if needed)
If you see this error when playing:
> 'InvalidOperationException: Your are trying to read Input using the UnityEngine.Input class'

Go to:
```
Edit -> Project Settings -> Player -> Active Input Handling -> Both
```


---

## Project Structure

```bash
HighwayHarvest/
|
| -- Assets/
|      | -- Scenes/
|      |       | -- SampleScene                         # Main game scene
|      |
|      | -- Scripts/
|      |       | -- carcontroller.cs                    # Jeep movement and wheel control
|      |       | -- Apple.cs                            # Fruit collision logic (per fruit)
|      |       | -- VehicleInventory.cs                 # Tracks collected fruit counts
|      |       | -- InventoryUI.cs                      # Updates on-screen score labels
|      |       | -- GameManager.cs                      # Controlls loding/restaring scenes
|      |
|      | -- Prefabs/
|      |       | -- Apple, Banana, Watermelon, Strawberry
|      |
|      | -- Sprites/                                   # Fruit Icon PNG images
|      | -- Materials/                                 # Terrain and road meterials
|      |
|      | -- Cinemachine                                # Thired person camera system
|      | -- Road Architect
|      | -- Arcade Racing Cars - Pickup Jeep
|      | -- Rock and Boulders 2
|      | -- Conifiers                                  # For add trees
|      | -- Grass And Flower Pack 1
|      | -- Country House
|      | -- FREE Stylized bear - RPG Forest Animal
|      | -- Wolf Animated
|      | -- Match 3D Object Pack: Fruits & Vegitables
|      
| -- Packages/
|      | -- manifest.json
|      | -- packages-lock.json                        # includes package details of the project

```

---

## How It Works
```bash
Player Press input kyes
         |
         V
  carcontroller.cs                <- applies motor and torque and steering to Wheel Colliders
         |
         V
Jeep moves through terrain
         |
         V
Fruit trigger collider fires
         |
         V
 Apple.cs /Banana.cs ...          <- calls VehicleInverntory.cs to increment fruit count
         |
         V
  VehicleInventory.cs             <- sores collected fruit counts on the vehicle
         |
         V
    InventoryUI.cs                <- reads counts and updats Canvas text labels
         |
         V
Score shown on Canvas
```

---
## Troubleshooting

**Input error when driving the jeep**
-> Go to `Edit -> Project Settings -> Player -> Active Input Handling -> Both`

**Jeep rolls over when turing fast**
-> Increase **Angular Damping** on the Jeep Rigidbody from `0` to `8`

**Roads,rocks,house or animals appear pink in the screen**
-> Go to `Window tool -> Rendering -> Render Pipeline Converter -> Material Upgrade -> Initialize Converters -> Convert Assets`

---

## License

This project is licensed under the MIT License - see [LICENSE](LICENSE) for details.

---

## Asset Credits
| Asset | Source |
| --- | --- |
| Cinemachine | [Unity Assest Store](https://assetstore.unity.com/)|
| Road Architect| [Road Architect](https://github.com/FritzsHero/RoadArchitect)|
| Arcade Racing Cars - Pickup Jeep | [Unity Assest Store](https://assetstore.unity.com/)|
| Rock and Boulders 2| [Unity Assest Store](https://assetstore.unity.com/) |
| Conifiers| [Unity Assest Store](https://assetstore.unity.com/) |
| Grass And Flower Pack 1| [Unity Assest Store](https://assetstore.unity.com/) |
| FREE Stylized bear - RPG Forest Animal| [Unity Assest Store](https://assetstore.unity.com/) |
| Wolf Animated| [Unity Assest Store](https://assetstore.unity.com/)|
| Match 3D Object Pack: Fruits & Vegitables| [Unity Assest Store](https://assetstore.unity.com/)|