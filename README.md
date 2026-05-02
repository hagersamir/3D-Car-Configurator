# 🧩 3D Car Configurator

An **interactive 3D car configurator system** built in Unity that allows users to directly interact with a 3D model and customize its components in real time through a responsive 2D UI overlay.

This project demonstrates **3D interaction, UI/UX integration, input handling, and real-time material/mesh updates**, delivering a smooth and polished product-style experience similar to real automotive or product configurators.

---

## 📚 Table of Contents

- [🎯 Project Overview](#-project-overview)
- [🚗 Configurable Model](#-configurable-model)
- [🧠 Core Features](#-core-features)
- [🎮 Interaction System](#-interaction-system)
- [🧩 UI Configurator Panel](#-ui-configurator-panel)
- [🔊 Audio & Feedback System](#-audio--feedback-system)
- [🧠 Technologies Used](#-technologies-used)
- [🚀 How It Works](#-how-it-works)
- [✨ Bonus Features](#-bonus-features)
- [📽️ Demo](#-demo)
- [👤 Author](#-author)

---

## 🎯 Project Overview

Modern product configurators allow users to explore, customize, and visualize complex 3D models in real time.

💡 This project implements a **fully interactive 3D car configurator system** where users can:

- Rotate and zoom a 3D car model using an orbit camera  
- Select individual parts directly in the 3D scene  
- Customize each part through a dynamic UI panel  
- See instant visual updates in real time  

The system bridges the gap between:
- **3D interaction (scene)**  
- **2D UI control (Canvas overlay)**  

---

## 🚗 Configurable Model

### A Car Model 

| Part | Feature |
|------|--------|
| 🚗 Body | Paint color (5 base colors + RGB gradient system) |
| 🛞 Wheels | Swap between multiple wheel styles |
| 🪟 Windows | Toggle tint (on/off) |
| 🪑 Interior | Change seat material/color  |

---

## 🧠 Core Features

- 🎯 Direct 3D Interaction (select parts with click)
- 🎥 Orbit Camera (rotate + zoom)
- 🧩 Dynamic Material System (real-time updates)
- 🖥️ Responsive UI Overlay (multi-resolution support)

---

## 🎮 Interaction System

- Raycast-based object selection  
- Highlight selected parts  
- Orbit camera rotation with mouse drag  
- Scroll zoom in/out  
- UI blocks camera input when active  

---

## 🧩 UI Configurator Panel

- 📌 Shows selected part name  
- 🧾 Tooltip system for each part (hover / focus info)  
- 🎨 Color picker / RGB sliders  
- 🔄 Variant switching (buttons / toggles)  
- 📜 Scrollable configuration summary  
- ⚙️ Real-time updates on 3D model  

### States:
- No selection → “Select a part to configure”  
- Hover → Tooltip appears  
- Selected → Configuration panel activates  

---

## 🔊 Audio & Feedback System

- 🎯 Part selection sound  
- 🧩 UI panel open/close sound  
- 🔘 Button click sound  
- 🎨 Lightweight, non-intrusive feedback system  

Improves:
- UX clarity  
- Interaction feedback  
- Overall polish  

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

1. 3D car model placed in garage scene   
2. Orbit camera enables interaction  
3. Raycast detects selected parts  
4. UI updates dynamically  
5. Changes apply instantly to materials  
6. Audio feedback enhances interaction  

---

## ✨ Features

- 🔁 Undo / Redo system  
- 📸 Screenshot capture (PNG export)  
- 🔄 Reset to default configuration  
- 📊 Scrollable configuration summary  
- 🎧 UI sound feedback system  
- ⚡ Smooth UI transitions (fade/slide)  

---

## 📽️ Demo


https://github.com/user-attachments/assets/85e11126-96fc-496a-a21b-b86c1eb9edfc



---

## 👤 Author

**Hager Samir**  
Unity Developer & Biomedical Engineer  
