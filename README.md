# 🧩 3D Car Configurator 

An **interactive 3D configurator system** built in Unity that allows users to directly interact with a 3D model and customize its components in real time through a responsive 2D UI overlay.

This project demonstrates **3D interaction, UI/UX integration, input handling, and real-time material/mesh updates**, delivering a smooth and polished product-style experience similar to real automotive or product configurators.

---

## 📚 Table of Contents

- 🎯 Project Overview  
- 🚗 Configurable Model  
- 🧠 Core Features  
- 🎮 Interaction System  
- 🧩 UI Configurator Panel  
- 🔊 Audio & Feedback System  
- 🧠 Technologies Used  
- 🚀 How It Works  
- ✨ Bonus Features  
- 📽️ Demo  
- 👤 Author  

---

## 🎯 Project Overview

Modern product configurators allow users to explore, customize, and visualize complex 3D models in real time.

💡 This project implements a **fully interactive 3D configurator system** where users can:

- Rotate and zoom a 3D model using an orbit camera  
- Select individual parts directly in the 3D scene  
- Customize each part through a dynamic UI panel  
- See instant visual updates in real time  

The system bridges the gap between:
- **3D interaction (scene)**  
- **2D UI control (Canvas overlay)**  

---

## 🚗 Configurable Model

### Option A — Car Model (Implemented)

| Part | Feature |
|------|--------|
| 🚗 Body | Paint color (5 base colors + RGB gradient system) |
| 🛞 Wheels | Swap between multiple wheel styles |
| 🪟 Windows | Toggle tint (on/off) |
| 🪑 Interior | Change seat material/color (optional extension) |

Each part is independently selectable and configurable.

---

## 🧠 Core Features

- 🎯 **Direct 3D Interaction**
  - Click/tap to select model parts
  - Real-time selection highlighting (outline/glow)

- 🎥 **Orbit Camera System**
  - Mouse drag rotation
  - Scroll zoom in/out
  - Smooth and constrained movement

- 🧩 **Dynamic Material System**
  - Instant color updates
  - RGB-based shading and gradient control
  - Mesh-specific material targeting

- 🖥️ **Responsive UI Overlay**
  - Fully anchored UI (multi-resolution support)
  - Clean configurator layout

---

## 🎮 Interaction System

### 🔹 3D Selection
- Raycast-based object selection
- Highlights selected part visually
- Updates UI based on selected object

### 🔹 Camera Control
- Left mouse drag → rotate model  
- Mouse wheel → zoom in/out  
- UI interaction automatically blocks camera control  

---

## 🧩 UI Configurator Panel

### Features:
- 📌 Displays selected part name  
- 🧾 Tooltip system for each part (hover or long-press shows part name + hint before selection)  
- 🎨 Color picker / swatches  
- 🔄 Variant switching (buttons / dropdowns)  
- 📜 Scrollable configuration summary  
- ⚙️ Real-time updates on 3D model  

### States:
- No selection → “Select a part to configure”  
- Hover/Focus → Tooltip appears with part information  
- Part selected → dynamic options appear   

---

## 🔊 Audio & Feedback System

To enhance user experience and make the configurator feel more interactive and premium, the system includes **light UI sound feedback**:

- 🎯 **Part Selection Sound**
  - Played when a 3D object is selected

- 🧩 **UI Panel Open/Close Sound**
  - Triggered when configurator panels appear or disappear

- 🔘 **Button Click Sound**
  - Played on all UI interactions (buttons, toggles, dropdowns)

- 🎨 **Feedback Purpose**
  - Improves user engagement
  - Provides clear interaction confirmation
  - Makes the experience feel responsive and polished

All audio effects are kept **subtle and non-intrusive** to maintain a clean UX.

---

## 🧠 Technologies Used

- Unity Engine  
- C#  
- URP (Universal Render Pipeline)  
- Unity UI (Canvas + TextMeshPro)  
- EventSystem + Raycasting  
- AudioSource System  
- DOTween / Unity Animation System  
- Git & GitHub  

---

## 🚀 How It Works

1. 3D model placed in centered scene  
2. Orbit camera enables rotation & zoom  
3. Raycast detects selected parts  
4. UI updates dynamically based on selection  
5. Changes apply instantly to materials/meshes  
6. Audio feedback reinforces every interaction  

---

## ✨ Bonus Features

- 🔁 Undo / Redo system  
- 📸 Screenshot capture (PNG export)  
- 🔄 Reset to default configuration  
- 📊 Scrollable configuration summary  
- 🎧 UI sound feedback system  
- ⚡ Smooth UI transitions (fade/slide animations)  

---

## 📽️ Demo


--- 
👥 Author

Hager Samir
Unity Developer & Biomedical Engineer
