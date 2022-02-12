(deffunction BrakeWorking;How the Braking System Works
()
(printout b crlf
            "Braking systems haven’t changed too dramatically in the history of automobiles."crlf
            "Like the first cars, most systems today use friction to slow the car down."crlf
            "Simple levers have been replaced with hydraulics, which apply greater pressure to the brakes for better stopping power, but the basic principle remains the same."crlf

            "Conventional brakes work by applying a brake pad to a braking surface, which generates friction."crlf
            "The car slows as its forward motion (kinetic energy)is converted into heat energy."crlf
            "Because the friction between the two surfaces creates heat, the braking system is designed to wear slowly and dissipate heat quickly."crlf
            "The brake system needs regular maintenance to keep you safe on the road."crlf
            "Most cars have three braking systems: the front or primary brake system (most of your braking comes from the front brakes), the rear or secondary brake system, and an emergency brake system, which is usually mounted with the secondary system."crlf
            " "crlf
            "  REGENERATIVE BRAKING."crlf
            "  Electric and hybrid cars are usually equipped with conventional brakes, but they can also take advantage of regenerative braking."crlf
            "  Regenerative brakes run the power in reverse through the electric motor, which acts as a resistance to the motor, slowing the car."crlf
            "  Cars that use regenerative braking rely less on the conventional hydraulic systems, which makes them last longer and run cooler."crlf
            " "crlf
)
)

(deffunction BrakeTypes;Types of Brakes and Brake Components
()
(printout b "TYPES OF BRAKES"crlf
            " "crlf
            "Disc Brakes: A disc brake uses hydraulic power to push the brake pads against a rotor that rotates in the same direction as the wheel."crlf
            "             Disc brakes use higher pressures and more fluid than drum brakes."crlf
            "             They don’t have springs to retract them away from the rotor, so they drag slightly against the rotor until needed."crlf
            "             Most cars have this type of braking system."crlf
            " "crlf
            "Drum Brakes: Drum brakes use friction pads to push against the sides of a drum."crlf
            "             Like disc brakes, they are hydraulic, but they use less pressure and fluid to operate."crlf
            "             Unlike disc brakes, drum brakes retain some hydraulic pressure, so they use a series of springs to retract them from the drums to prevent drag."crlf
            "             This makes them more complex to refurbish."crlf
            " "crlf
            "Mechanical or Emergency Brakes:"crlf
            "             The emergency brake system is a mechanical backup in case the hydraulic system fails."crlf
            "             By pulling a lever or pressing the foot switch, you can engage the brakes manually."crlf
            "             The mechanical system usually has a method of holding the brakes in an “on” position for emergency situations or if you have to park on an incline and you need to set the brakes to hold the car in place."crlf
            " "crlf
            "BRAKE COMPONENTS"crlf
            " "crlf
            "Brake Pads:  The brake pads, also called brake shoes, are coated with a friction material that is designed to wear away by changing the motion of your car into heat, and this stops the car."crlf
            "             They can be made of many different types of materials including natural and manmade fibers, fibers mixed with metals (semi-metallic), ceramics, and other components."crlf
            "             The type of brake pad you need is determined by the car manufacturer."crlf
            "             Only change the type of pad you use if you have changed the use of your car (For example, high-performance vehicles usually have upgraded brakes and brake pads.)"crlf
            "             The brake pads are designed to wear away, and they need to be replaced at regular intervals."crlf
            " "crlf
            "Rotor:       The rotor is the big, heavy piece that the brake pads push against to stop the car."crlf
            "             They are usually made of metal and may be coated with ceramic or other material to help them resist or dissipate heat faster."crlf
            "             Most primary brake rotors are vented, which means they have holes running through the outside of the rotor."crlf
            "             These help the rotor dissipate heat by allowing airflow between the metal braking surfaces."crlf
            "             Some rotors have holes through them and slots cut in the braking area (called “cross-drilled” or “slotted” rotors)."crlf
            "             These help the rotor remove heat faster, remove gas, and remove water picked up off the road from the braking components."crlf
            "             They are usually used on performance cars."crlf
            " "crlf
            "Master Cylinder :The master cylinder has a reservoir that holds the fluid and regulates the flow of the hydraulic brake fluid."crlf
            "When you push the brake pedal, the master cylinder pushes the brake fluid out to the primary and secondary brake systems."crlf
            "It keeps the two systems separate, so if one system fails, you still have the other."crlf
            " "crlf
            "Calipers and Brake Cylinders: These components are at the end of the hydraulic system. They apply the force to push the brake pads against the braking surface."crlf
            "Calipers use one or more pistons to press a pad against the brake rotor, which pushes the caliper outward and squeezes the two pads against the rotor."crlf
            "A brake cylinder pushes both brake pads out at the same time,and uses springs to retract them back into position."crlf
            " "crlf
            "Power Brake Boosters:A power brake booster uses vacuum,hydraulic, or electric power to increase the amount of pedal pressure you can apply to the brakes."crlf
            "It is usually mounted between the brake pedal and the master cylinder."crlf
            "Your foot applies around one-tenth of the pressure power brakes can apply, which allows manufacturers to design power brakes to work better with increased ease for the driver."crlf
            " "crlf
            "Anti-Lock Brakes (ABS):Most cars have anti-lock brakes to help you slow safely in slippery conditions."crlf
            "When your brakes lock up,you are no longer using the brake pads to convert forward motion into heat,you are using the surface of your tires."crlf
            "ABS can sense if a wheel has stopped prematurely and will release brake pressure to that wheel, enabling it to move and transfer energy back to the brake pads."crlf
            "The ABS is mounted between the master cylinder and the four braking points."crlf
            "If the ABS engages, you will feel the brakes pulse as the brakes are applied and then released by the ABS."crlf
            "This pulsing is normal,and by pulsing the brakes the ABS can slow the car much faster than skidding."crlf
            " "crlf
            "Hydraulic and Mechanical Lines:Hydraulic brakes use a series of flexible and non-flexible lines to carry the high hydraulic pressures from the master cylinder to the calipers or brake cylinders."crlf
            "Emergency mechanical brakes generally use cables attached to the secondary brake system to engage."crlf
            " "crlf
)
)

(deftemplate BrakeProblems;Common Braking System Problems

(slot sound
(type SYMBOL)
(allowed-symbols metal-on-metal-grinding  squeal  no-sound)
)

(slot vibration
(type SYMBOL)
(allowed-symbols YES NO)
)

(slot pulling
(type SYMBOL)
(allowed-symbols YES NO)
)

(slot push
(type SYMBOL)
(allowed-symbols hard normal)
)

)

(defrule Brake


    (BrakeProblems (sound  metal-on-metal-grinding|squeal) (vibration YES)  (pulling YES) (push hard))

=>
(printout b 
            "NOISY BRAKES: The brakes should not make any noise when operating. If they squeal or make a metal-on-metal grinding sound, the brake pads are probably worn and need to be replaced."crlf
            "It is important to replace worn pads quickly,as they can grind or imbed friction material on the rotors."crlf
            "Brakes may also squeal if they become glazed.Brake glaze occurs when heat hardens the metal rotor or pads, making them shiny and smooth, a condition that can reduce their effectiveness and require replacement."crlf
            " "crlf
            "VIBRATION: You may notice the car shuddering as you apply the brakes and the shuddering slowing as the car slows down."crlf
            "This vibration is usually caused by a crack in the rotors, uneven wearing of the pads or shoes, or the transfer of the friction material onto the rotor surface."crlf
            "If you find a crack in either the metal or ceramic coating of the rotor or drum, the rotor or drum will need to be changed."crlf
            "Replace unevenly worn brake pads, and have the rotor turned (resurfaced) to even out the surface."crlf
            "Embedded brake pad material can be machined off the rotors if they are not already too thin."crlf
            " "crlf
            "It is possible, although less likely, that a warped rotor is causing the vibrations."crlf
            "Rotors can become warped if too much material is removed when the rotor is turned, and a warped rotor needs to be replaced."crlf
            "Rotors generally should be turned when a regular brake job is performed to clean and even out the braking surface."crlf
            " "crlf
            "PULLING TO ONE SIDE: If you notice the car pulling to one side when you apply the brakes, it is likely due to contamination in the brake components, or a faulty caliper or brake cylinder."crlf
            "It can also happen if you have differently sized tires,such as when you’re driving on a temporary spare."crlf
            "Worn suspension parts can also cause this problem."crlf
            " "crlf
            "SOFT OR SPONGY BRAKES: You may begin to notice over time that you have to push harder on the brake pedal to engage the brakes and bring the car to a stop."crlf
            "If the brakes are still working, the usual suspects include low fluid level, worn pads,worn out or dirty fluid, or a failed booster."crlf
            "As disc brakes wear, they don’t retract like drum brakes, so the level of fluid decreases."crlf
            "If you go too long without adding more fluid or changing the fluid, they can give you excessive brake pedal travel."crlf
            "If the brake pedal goes to the floor but you have little or no braking action, the brakes have lost the ability to produce pressure."crlf
            "This can be caused by a break or leak in the lines or brakes, or a failure of the master cylinder or distribution block."crlf
            " "crlf
)
)

(deffunction BrakeInspect;How to: Inspect the Brakes
()
(printout b " "crlf
            "How to:Inspect the Brakes"crlf
            " "crlf
            "You should check your brakes or have them inspected about every 10,000 miles or 15,000 kilometers"crlf
            "You can inspect disc brakes on your own, but you may want to leave the more complicated drum brakes to a professional."crlf
            "When inspecting the brakes, be cautious with heat, brake dust and brake fluid."crlf
            "Wearing gloves and eye protection is strongly recommended."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            "  Jack and jack stands."crlf
            "  Safety gloves and eye protection."crlf
            "  Torque wrench and socket."crlf
            " "crlf
            "1. RAISE THE VEHICLE AND REMOVE A WHEEL."crlf
            " "crlf
            "Check the brakes one wheel at a time, and when the brakes are cool."crlf
            "Removing the wheel will give you the best access for inspecting the brakes."crlf
            " "crlf
            "2. INSPECT THE ROTOR."crlf
            " "crlf
            "The rotor should be smooth, but not glossy.You may notice some very tiny ridges in the rotor, or a ridge on the outside edge.These are normal."crlf
            "    Look for discoloration This may indicate overheating, embedded brake pad material, or a rotor that is made of inferior materials."crlf
            "    Look for signs of uneven wear If you can,spin the rotor by hand and listen to the sound."crlf
            "    A disc brake does not retract, so you should hear an even sound of the pad lightly touching."crlf
            "    If it sounds uneven, you may have a problem with the brakes."crlf
            "    Look for cracks or gouges in the rotor If you find any, the rotor will need to be replaced."crlf
            " "crlf
            "3. INSPECT THE CALIPER."crlf
            " "crlf
            "If the caliper is cold, wiggle it back and forth to make sure it isn’t loose and the mounts have not worn out."crlf
            "Look for signs of leaking brake fluid inside and outside."crlf
            " "crlf
            "4. INSPECT THE BRAKE PADS."crlf
            " "crlf
            "There should be a minimum of 1/8 inch to 3/16 inch of material on the brake pads between the rotor and the metal backing plate."crlf
            "A good rule of thumb is that the pad material should be thicker than the backing plate."crlf
            "If one pad is wearing more than the other, there may be a problem with the piston or slide pins on the caliper.Look for even, flat wear."crlf
            " "crlf
            "5. INSPECT THE BRAKE LINES."crlf
            " "crlf
            "Check the fluid lines coming in to the brake caliper for abrasions, rust, or kinks."crlf
            " "crlf
            "6. REINSTALL THE WHEEL AND TORQUE THE LUG NUTS."crlf
            " "crlf
            "Make sure you properly reinstall the wheel before removing the safety stands and moving to the next wheel."crlf
            crlf
            ""crlf
)

)

(deffunction BrakePad;How to: Change Brake Pads and Rotors
()
(printout b crlf
            "How to: Change Brake Pads and Rotors."crlf
            " "crlf
            "Changing the pads and rotors on most front-wheel drive cars is not terribly difficult."crlf
            "However, it’s important to keep in mind that all cars are designed differently.Have a shop manual for your vehicle on hand, and only change the pads and rotors on one side of the car at a time so you can use the other side as a reference."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            " Jack and jack stands."crlf
            " Safety gloves and eye protection."crlf
            " New pads and rotors."crlf
            " Torque wrench and socket."crlf
            " Tools to remove the caliper and caliper mount."crlf
            " Disc brake spreader or a C-clamp and block of wood."crlf
            " Brake assembly grease."crlf
            " Turkey baster (if needed)."crlf
            " "crlf
            "1. RAISE THE VEHICLE."crlf
            " "crlf
            "Raise your vehicle safely using the jack and car stands."crlf
            " "crlf
            "2. REMOVE ONE WHEEL."crlf
            " "crlf
            "Use the torque wrench and socket to remove the lug nuts and pull one wheel from the vehicle."crlf
            " "crlf
            "3. OPEN THE MASTER CYLINDER."crlf
            " "crlf
            "Twist off the master cylinder cap to allow air to escape when you compress the caliper piston."crlf
            " "crlf
            "4. INSPECT THE ROTOR."crlf
            " "crlf
            "Look for deep grooves, discoloration, and glazing."crlf
            " "crlf
            "  TIP: Most rear-wheel-drive cars have drum brakes or disc brakes that ride on a spindle."crlf
            "       These designs are complicated and require special equipment.You may want to leave changing the pads and rotors on these types of brakes to a professional."crlf
            " "crlf
            "5. REMOVE THE CALIPER."crlf
            " "crlf
            "There are two types of brake calipers, floating and fixed."crlf
            "Most brakes are floating which means they move on a set of slides and have one or more pistons on one side to push the caliper against the rotor."crlf
            "A fixed caliper has one or more pistons on both sides, and it is mounted so it can’t move."crlf
            "The pistons push the pads from both sides rather than from one side."crlf
            "If you are doing rear brakes, you may need to remove the emergency brake cable to get the caliper out of the way to remove the rotor."crlf
            " "crlf
            "6. SECURE THE CALIPER AND REMOVE THE BRAKE PADS."crlf
            " "crlf
            "There are usually two bolts holding a floating caliper."crlf
            "Remove these two bolts and secure the caliper up and out of the way."crlf
            "Be sure not to put any strain on the flexible brake line."crlf
            "The brake pads may or may not come out by hand.A fixed pad may need to be removed with a tool. "crlf
            " "crlf
            "7. INSPECT THE CALIPER."crlf
            " "crlf
            "With the old pads out, you can inspect the caliper piston.Check the seal between the caliper and piston for breaks, tears, and leaks."crlf
            "Clean the loose rust and debris out of the caliper area."crlf
            " "crlf
            "8. REMOVE THE CALIPER MOUNT."crlf
            " "crlf
            "It may be necessary to remove the caliper mount or other brackets to get the rotor off of the car."crlf
            "These may be hard to remove as they typically are installed with a lot of torque and sometimes manufacturers use thread locker to hold them in place."crlf
            " "crlf
            "9. REMOVE THE ROTOR."crlf
            " "crlf
            "Some manufacturers use little clips to hold the rotor to the car while it is being assembled."crlf
            "Save these if you can.They can be reused to hold the rotor in place when reassembling the brakes."crlf
            "The rotor may stick to the metal hub on which it’s mounted."crlf
            "Use a mallet and gently knock the rotor loose and remove it from the car."crlf
            " "crlf
            "10. INSTALL THE NEW ROTOR AND BRACKETS."crlf
            " "crlf
            "Install the new rotor,using your clips if you still have them."crlf
            "Reinstall the brackets and check your shop manual for the correct torque specification for the brackets."crlf
            " "crlf
            "11. INSPECT THE OLD PADS."crlf
            " "crlf
            "Check the old pads for uneven wear, both on the individual pad and against the other pad."crlf
            " "crlf
            "12. PUSH THE PISTON BACK INTO THE CALIPER."crlf
            " "crlf
            "Disc brakes don’t retract like drum brakes, so to install the new thicker pads, the piston has to be pressed back into the caliper."crlf
            "You can purchase a special tool to do this, or you can use a big C-clamp and a piece of wood."crlf
            "The wood helps to spread the pressure around the piston and keep it going straight."crlf
            "Take your time and press the pistons back slowly.You’re pushing the brake fluid back into the master cylinder and you don’t want to rush."crlf
            "Once the piston is flush with the seal, you are done."crlf
            " "crlf
            "13. GREASE THE SLIDE PINS."crlf
            " "crlf
            "The slide pins are used to move a floating caliper in and out. Your caliper will mount to these pins."crlf
            "Remove them, clean off the old grease, and apply new brake grease.Inspect the pin covers for any tears and replace if necessary."crlf
            " "crlf
            "14. GREASE AND INSTALL THE NEW PADS."crlf
            " "crlf
            "To reduce the amount of noise coming from your brakes, apply brake assembly grease to the brake pad."crlf
            "Grease the back of the pad that touches the piston, the metal tabs where the back of the brake pad touches the caliper, and the pad retainers."crlf
            "Install the new pads in the caliper. If they are installed with clips, use new clips provided by the pad manufacturer."crlf
            " "crlf
            "15. REINSTALL THE CALIPER."crlf
            " "crlf
            "Reinstall the caliper and slide pins and tighten to your manufacturer’s specifications."crlf
            "Spin the wheel and make sure everything turns freely. The pads may not touch the rotor yet since you retracted the piston."crlf
            " "crlf
            "16. CHECK THE FLUID LEVEL AND REINSTALL THE WHEEL."crlf
            " "crlf
            "Since you pushed fluid back up into the master cylinder, the fluid level may be high."crlf
            "If it is, remove the excess with a turkey baster."crlf
            "Once the level is good, reinstall the wheel and torque the lug nuts."crlf
            " "crlf
            "17. LOWER THE CAR AND REPEAT WITH REMAINING BRAKES."crlf
            " "crlf
            "After lowering the car, begin the process again with the brakes on the opposite side of the car."crlf
            " CAUTION!!"crlf
            " "crlf
            " One of the big reasons brakes fail is due to improper seating."crlf
            " Different brakes require different methods to seat them and make sure they don’t embed material into the new rotors."crlf
            " Follow your brake manufacturer’s recommendation, which can usually be found on the box with the pads."crlf
            " "crlf
            "18. SEAT THE BRAKES."crlf
            " "crlf
            "Once both or all the brakes have been replaced and your master cylinder level has been set and closed, pump the brakes several times to reset the brake pads against the rotor."crlf
            "Do this before test driving the car."crlf
            " "crlf
            "TURNING YOUR ROTORS:Whenever you change your brake pads, you should have your rotors turned or install new rotors."crlf
            "                    This is important because the brake pads and rotor are designed to press flat against each other, and when brake pads wear, they don’t wear flat."crlf
            "                    If you change your pads but don’t replace or turn the rotors, you will have a flat pad pressing against an angled rotor. Until the pads wear to match the worn rotor, your brakes will not perform optimally."crlf
            "                    If you don’t want to replace your rotors, you may be able to have them turned by a mechanic."crlf
            "                    Turning (also called resurfacing or machining) is a process in which a very small amount of material is removed from the rotor surface to make it even again."crlf
            "                    This can only be done if your rotors are not too worn. If your rotors are too thin, they will need to be replaced."crlf
            "                    You can measure the thickness of the rotor, but doing so properly requires special tools."crlf
            "                    If you are changing pads, it’s best to let a mechanic measure the rotors. They’ll have the right tools and the know-how, and you can still save some money doing the rest yourself."crlf
            " "crlf
)
)

(deffunction BrakeFluid;How to:Check and Fill Brake Fluid

()
(printout b " "crlf
            "How to:Check and Fill Brake Fluid"crlf
            " "crlf
            "Hydraulic brakes have a reservoir of brake fluid mounted on top of the master cylinder."crlf
            "As you press on the brakes, fluid is drawn from the reservoir, and when you let off the brakes, the fluid is returned."crlf
            "If the fluid level gets too low, the brakes  could draw air into the brake system, which could prevent the brakes from operating properly."crlf
            "The brake fluid can also become contaminated with soot from use.Brake fluid should be checked and changed regularly."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            "  Brake fluid"crlf
            "  Latex or nitrile gloves"crlf
            "  Safety glasses"crlf
            "  Turkey baster (optional)"crlf
            " "crlf
            "1. LOCATE THE MASTER CYLINDER RESERVOIR."crlf
            " "crlf
            "The master cylinder is usually mounted near the brake pedal in the engine compartment."crlf
            "Look for the minimum and maximum level lines on the side of the reservoir."crlf
            "Under normal driving conditions, the fluid level should stay near the maximum line and not go down too much."crlf
            "If the level is down, there may be a leak in the brake system, or the disc brake caliper pads may have worn down and need to be replaced."crlf
            " "crlf
            "2. WIPE OFF THE MASTER CYLINDER."crlf
            " "crlf
            "Before you add fluid or open the reservoir to check it, it’s a good idea to wipe the top and cap clean so you don’t get any dirt down in the master cylinder."crlf
            "Outside contaminants can clog the hydraulic system."crlf
            " "crlf
            " CAUTION!!"crlf
            "    Brake fluid is corrosive and should not come in contact with your skin."crlf
            "    Wear latex or nitrile gloves and safety glasses when handling brake fluid."crlf
            " "crlf
            "3. INSPECT THE FLUID."crlf
            " "crlf
            "Look down in the reservoir and inspect the fluid or use a turkey baster to draw out some fluid, if needed."crlf
            "Brake fluid should be clear or amber in color."crlf
            "If your brake fluid is dirty, bleed the brake system before adding more fluid."crlf
            " "crlf
            "4. ADD FLUID, IF NEEDED."crlf
            " "crlf
            "If your brake fluid is clean but low, add fluid to the maximum level mark on the side of the reservoir and replace the cap."crlf
            "If you put in too much, use a turkey baster to remove the fluid until it is at the correct level."crlf
            "Low fluid levels can indicate a leak in the system, so inspect the brakes for wear or leaking."crlf
            " "crlf
)
)


(deffunction  BrakeBleed;How to: Bleed the Brake System
()
(printout b crlf
            "How to:Bleed the Brake System."crlf
            " "crlf
            "You need to bleed the brakes if there is air in the brake lines or if the fluid needs to be changed."crlf
            "You can use one of three different methods: the gravity method, pressure bleeding, or vacuum bleeding."crlf
            "The gravity method is the simplest, and relies on gravity to drain the fluid and air."crlf
            "Pressure bleeding uses the brake pedal to force out the air and fluid,and vacuum bleeding uses a vacuum pump on the end of the line to draw out the fluid and air."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            "  Brake fluid."crlf
            "  Line Wrench."crlf
            "  Clear jar(for gravity and pressure bleeding)."crlf
            "  Clear plastic tubing."crlf
            "  Vacuum pump (for vacuum bleeding)."crlf
            "  Grease(optional)."crlf
            "  Rust-penetrating spray (optional)."crlf
            "  Jack and jack stands (if needed)."crlf
            "  Latex or nitrile gloves and safety glasses."crlf
            " "crlf
            "GRAVITY BLEEDING"crlf
            " "crlf
            "Gravity bleeding is the easiest way to bleed the brakes. You simply open the bleeder screws and allow gravity to do the rest of the work."crlf
            "Be sure to recycle the used brake fluid properly when done".crlf
            " "crlf
            "1. RAISE THE CAR AND SECURE IT."crlf
            " "crlf
            "If you need room to work under your car, carefully raise the car and secure it with jack stands."crlf
            " "crlf
            "2. LOCATE THE BRAKE BLEED SCREWS."crlf
            " "crlf
            "The bleed screws are usually located on the top of the calipers and brake cylinders."crlf
            "They look like a thick hex screw with a hole in the end.Sometimes they have a rubber cap on the end to keep out dust."crlf
            "If needed, apply a little penetrating spray on the bleed screws to help loosen them."crlf
            " "crlf
            "3. PREPARE THE MASTER CYLINDER."crlf
            " "crlf
            "Top off the master cylinder. For gravity bleeding and vacuum bleeding, you need to remove the cap."crlf
            "For pressure bleeding, you need to close the cap. Regardless of which method you use, it is important that you do not let the master cylinder go empty."crlf
            "If it gets too low, air can be drawn into the brake system."crlf
            " "crlf
            "4. CONNECT THE TUBING AND OPEN THE BLEED SCREWS."crlf
            " "crlf
            "Place one end of the clear tubing in a catch jar, connect the other end to each bleed screw to be bled, and carefully open the bleed screws."crlf
            "The tubing will spin with the screw. It doesn’t take much (quarter to a half turn usually) to open the screw and start letting the brake fluid out."crlf
            "Let the system continue to flow until you see the fresh new fluid coming out."crlf
            "If doing only the front or rear brakes, open both screws on that system. If doing both front and back, open all four."crlf
            "Gravity feeding can take a while. Be sure you keep an eye on the fluid level in the master cylinder, and top off the fluid as it draws down."crlf
            " "crlf
            "5. CLOSE THE BLEED SCREWS AND TOP OFF THE MASTER CYLINDER."crlf
            " "crlf
            "When you begin to see clean, fresh fluid coming through the hose, you can close the bleed screws and remove the hose.Top off the master cylinder and wipe up any spilled fluid."crlf
            " "crlf
            "6. CHECK YOUR BRAKES BEFORE DRIVING."crlf
            " "crlf
            "With your vehicle running and stationary, check your brakes for a firm pedal before operating the vehicle.Allow the vehicle to move slowly and check the brakes several times."crlf
            "If you have any concerns,do not operate the vehicle, and take it to a professional as soon as possible."crlf
            " "crlf
            "7. RECYCLE THE USED BRAKE FLUID."crlf
            " "crlf
            "Be sure to dispose of old brake fluid properly by putting it in an appropriate container and taking it to an auto parts dealer or recycling station.Never reuse old brake fluid."crlf
            " "crlf
            " "crlf
            "PRESSURE BLEEDING WITH TWO PEOPLE"crlf
            " "crlf
            "The pressure bleeding method uses the brake pedal to help force the air and fluid through the system. It’s easiest to do this job with the help of another person."crlf
            " "crlf
            "1. PREPARE VEHICLE FOR PRESSURE BLEEDING."crlf
            " "crlf
            "Follow the instructions for Gravity Bleeding, steps 1 through 3."crlf
            " "crlf
            "2. APPLY GREASE TO THE BLEED SCREWS.(OPTIONAL)"crlf
            " "crlf
            "Applying a little grease around the screw base and the opening at the top helps to seal the threads and tube when you release the brake pedal."crlf
            " "crlf
            "3. PREPARE THE CATCH JAR."crlf
            " "crlf
            "Partially fill the jar with clean brake fluid and place one end of the tubing in the jar, below the fluid level."crlf
            "This will allow the bubbles to escape, and if anything gets pulled back up in the tube it will be fresh brake fluid."crlf
            " "crlf
            "4. ATTACH THE TUBE TO THE BLEED SCREW."crlf
            " "crlf
            "Attach the other end of the tube to the first bleed screw, making sure it is snug. Begin with the brake that is farthest from the master cylinder."crlf
            "This is usually on the passenger side. If doing all four brakes, begin with the rear passenger-side brake."crlf
            " "crlf
            "5. PUSH THE BRAKE PEDAL AND OPEN THE BLEED SCREW."crlf
            " "crlf
            "Repeat this process of pushing the pedal, opening the screw, and closing the screw until new, clean fluid comes through the tube."crlf
            " "crlf
            "7. REPEAT WITH THE NEXT BRAKE LINE."crlf
            " "crlf
            "Once you have clean fluid coming through the tube, close the bleed screw and repeat the process with the next brake line until all brakes have been bled."crlf
            "Make sure you keep the master cylinder topped off and reinstall the cap after each top-off."crlf
            " "crlf
            "8. CLEAN UP AND TEST THE BRAKES."crlf
            " "crlf
            "Follow the instructions for Gravity Bleeding,steps 6 and 7, to clean up and test the brakes."crlf
            " "crlf
            " "crlf
            "VACUUM BLEEDING."crlf
            " "crlf
            "Vacuum bleeding brakes uses a vacuum pump to draw fluid out of the brake end of the system."crlf
            "It can be done by one person, but you will need to purchase a vacuum pump, which usually comes equipped with its own reservoir and tubing."crlf
            " "crlf
            "1. PREPARE THE VEHICLE FOR VACUUM BLEEDING."crlf
            " "crlf
            "Follow steps 1 through 3 for Gravity Bleeding, and steps 2 and 3 for Pressure Bleeding."crlf
            ""crlf
            "2. ATTACH THE VACUUM PUMP TO THE BLEED SCREW."crlf
            " "crlf
            "Attach the tube end of the pump to the bleed screw. Make sure the tube fits tightly around the screw to prevent air leaks."crlf
            " "crlf
            "3. APPLY VACUUM TO THE PUMP."crlf
            " "crlf
            "Pump the vacuum pump up to about 15 psi and open the bleed screw."crlf
            "As the fluid begins to flow, check for bubbles through the clear tube. Keep about 10 psi on the line. When you don’t see any more bubbles,close the bleed screws and release the vacuum."crlf
            " "crlf
            "4. REPEAT ON REMAINING BRAKE LINES."crlf
            " "crlf
            "Repeat the process until all brakes have been bled. Be sure to check the fluid level in the master cylinder as you go."crlf
            " "crlf
            "5. CLEAN UP AND TEST THE BRAKES."crlf
            " "crlf
            "Follow the instructions for Gravity Bleeding, steps 6 and 7, to clean up and test the brakes."crlf
            " "crlf
            " "crlf
            "     DISPOSING OF USED BRAKE FLUID:"crlf
            " "crlf
            "     Used brake fluid is a hazardous material and must be disposed of properly."crlf
            "     The rules for disposing of brake fluid and other automotive fluids vary by region, so check with your local recycling center or auto parts store to find out about the regulations in your area."crlf
            "     In some places, you are allowed to pour the used brake fluid into a pan of kitty litter and let it evaporate. The litter can then be thrown away in non-recyclable waste."crlf

            " "crlf
            "     CARS WITH ANTI-LOCK BRAKES (ABS):"crlf
            "  "crlf
            "     The anti-lock brake controller is located between the master cylinder and the brake ends."crlf
            "     It has small passages to bypass fluid and pressure while operating."crlf
            "     If air gets into the ABS unit, then it has to be purged by a professional using a pressure system and a computer."crlf
            "     It’s not possible to remove all of the air by simply bleeding the brakes alone."
            "     "crlf
            "     If you have air in the lines after the ABS box, you can bleed the brakes normally."crlf
            "     If you have air in the lines between the master cylinder and ABS box, you will need to have the ABS system purged by a professional."crlf
            "     You can bleed the brakes as normal and then carefully take the car to the mechanic (without activating the ABS)."crlf
            "     When in doubt, leave the brake bleeding to the professional."crlf
            " "crlf)
)