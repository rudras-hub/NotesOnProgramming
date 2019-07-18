# Object Oriented Design - Notes
## Module 1 : Analysis and Design 
- Benefits of object oriented design: 
    * Organized : Related code at same place (class)
    * Flexible : Easy to make changes without breaking rest of the code
    * Reusable : Reduces code duplication.
- Software Design Process
    * Requirements - _Whats_. Conditions that must be implemented. Elicit requirements by probing.
    * Conceptual Design - mockups, UI sketches etc. Recognize important _Components_, _Connections_ and _Responsibilities_. High level concepts
    * Technical Design - Technical diagrams. How specific responsibilities of each component are met.Breaking down into smaller and smaller components with specific responsibilities defined for each one.  
    * Implementation : Coding
- Quality Attributes : _How well_ the functionality must work. Performance, Security, Convenience etc. Often involves trade-offs between them.
- Context : Context to decide and strike balance between quality attributes. Security application = more security. Large scale application = more convenience etc. 
- Consequences : Does the s/w have unintended consequences when applied to a slightly different perspective. Ex: with big data set vs small data set. 
- Non-functional Requirements : _How Well._ Re-usability, Maintainability and Flexibility of the software. (Also quality attributes)
- Common Trade-offs : Performance vs Maintainability. Performance vs Security. 
- Backward Compatibility : Allows for inter-operability with an older legacy system. Inter-operability = ability to use interfaces and data from earlier versions.
- Forward Compatibility : System that is designed in such a way that it fits with future planned versions of itself. 
- Class Responsibility Collaborator (CRC) Cards
    * Technique to identify components or classes, their responsibilities and their collaborator/connections. 
    * Used at the conceptual design phase, helps breaking down of components into smaller ones and identification of additional components. Collaborators are places next to each other
    * Help in physically recognizing the software system. 
    * Moving cards around can help analyze alternative designs. 
- User Stories
    * A technique to express __requirements__. It is expressed from the perspective of the end user.
    * Format : As a (___), I want to (___), So that (___) 
        * First Blank : User role. 
        * Second Blank : Goal the user wants to achieve = feature implementation in sw
        * Third Blank : Benefits of achieving the goal. 
    * Recognizing classes: Nouns 
    * Recognizing Responsibilities : Verbs 
    * Connections are also implied by user stories; just more subtly. 
- Categories of objects
    * Entity Objects : Represent real world entities; user, chair, invoice etc. 
    * Boundary Objects: Sit at the boundary between systems. Responsible for sharing and getting information from other systems like internet, another software, a user etc. 
    * Control Objects : These co-ordinate information and activities between other objects. 

## Module 2 : Modelling
- For Object Oriented Languages: 
    * Conceptual Design = Identifying key objects and breaking them down to manageable pieces (Object Oriented Analysis). 
    * Technical Design = Refining the objects; including details about their attributes and behavior (Object Oriented Design).
- Creating Models in Design 
    * Models help organize and understand the design process. 
    * Goal of software design is to construct models for all objects in the software. 
    * _Design principles and guidelines_ are applied to simplify objects in the model, break them down into smaller parts and look for commonalities that can be consistently handled. 
    * Models can be mapped to skeletal code and serve as design documentation for the software. 
    * UML is used to often express the models. Different types of UML diagram to focus on different software issues.
- Four Major Design Principles:
    * Abstraction : Breaking a concept down into simplified description ignoring the unimportant details. 
        * Essential attributes and behaviors must be covered with no surprises/definitions beyond it's scope. 
        * Context : Context helps determine the essential characteristics.Essential characteristics of a person class will change if it's a gaming app or running app etc. IF the context changes, abstractions must be re-examined.
        * Essential Characteristics : Basic Attributes and Basic Behaviors. Attributes and behaviors that any instance of the class must have. 
        * Advantages : Simplified and focused design. Understandable design. 
    * Encapsulation : Code contained in capsule; some of which can be accessed from outside some that can not. Some methods are exposed to other classes to provide an "interface" for them to use this class. Major    ideas behind encapsulation:
        * Bundling : Bundling of data and functions that modify that data into same object. Data and code that manipulates that data are located in the same place (class).
        * Changeable Implementation (Black Box) : Exposing certain data through an interface. Implementation (or the actual bundle can change) but the accessible (exposed) interface must remain the same. Classes should be like black boxes to other classes; computation inside the class need no be known to others but the interface should be accessible.
        * Data Integrity : Restricting access to certain data within the class only. These can then be accessed indirectly through specific methods only. Data can thus not be changed through variable assignments. Hides sensitive information 
        * Advantages : Reduces complexity for client code, increases reusability, modular and easy to manage. 
    * Decomposition : Breaking of whole into parts or coming together of parts to form a whole. General Rule : Evaluate different responsibilities of the whole and separate them into parts. Each part can prescribe a class, abstract class etc. Nature of parts: 
        * Number of a certain type of part can be fixed or dynamic.
        * A part can be a whole in itself (and a part of a bigger system (whole))
        * A part can have it's lifetime tied to the whole (dies when the whole dies) or can have independent lifetime (usually dies before the whole?)
        * Parts maybe shared among wholes, this may not be intended some times. 
    * Generalization : Inheritance. Reduce redundancy in solution. Ensures the _Don't Repeat Yourself (D.R.Y)_ rule. 
        * Parent Class (Super-class) : Forms generalizations. Place for common methods, attributes etc. 
        * Children Classes (Sub - class) : Form specialization. They add attributes and methods on top of the inherited generalized methods.
        * Advantages : Easy to maintain, expand. Reusability. 
- Design Structures in Java and UML Class Diagrams: Conceptual design = CRC Cards. Technical design = UML (Class) Diagrams, more detailed and easier conversion to code. How to achieve the four major design principles through UML diagrams: 
    * Abstraction: Once the essential characteristics have been identified they can be represented in UML in a rectangle with three layers: Class Name, Properties and Operations.
        * Class Name : Name of the class
        * Properties : Attributes/ Member variables. Format `<variable name> : <variable type>`
        * Operations : Methods/ behaviors of the class. Format  `<name>(<parameter list>): <return type>`. 
        * UML Diagrams factor the responsibilities out into properties and operations which CRC cards do not.  
    * Encapsulation
        * Bundling : Already bundled by declaring properties and methods for those properties in the same class. 
        * Restriction : Private and Public members can be differentiated by add a `-` or a `+` respectively before declaring them in UML. Minus = hidden
        * Getters (retrieve data of private member variables) and Setters (change data of private member variables) are declared in the Operations section with a `+` sign (public access).   
    * Decomposition : Three different types of _relationships_ to define the relation between a whole and its parts: 
        * Association : A lose/independent relation ship. Any number of one object can depend on the other and their lifetimes are independent. No one belongs to the other; no one is a whole or a part. 
            * Indicated By:  straight line
            * Number : `0..*` next to the _other object_ i.e. one object is associated with 0 or more number of other object.
            * Example : An object type passed as a parameter to a method of the other object class.  
        * Aggregation : One is a whole the other is a part. "_Weak_ has-a" relation i.e. the whole and part can exist independently of the other. 
            * Indicated By : Straight line with a _empty diamond_ next to the whole. 
            * Number : `0..*` next to the _other object_
            * Example : When one type of object (whole) consists of a member variable of the other type (the part). 
        * Composition : "_Strong_ has-a" relationship. The whole can not exist without the part and destruction of whole will destroy the part. The part can only be accessed through its whole.
            * Indicated By : Straight line with a _filled-in_ diamond next to the whole.
            * Number : `1..*` next to the _part_ i.e. the whole is associated with 1 or more number of the part.
            * Example : An object (whole) consists of a member variable of the other type (part) + the member is initialized within the whole's constructor.
    * Generalization : Inheritance. 
        * Represented by a solid arrow with super-class at the head and sub-class at the tail. 
        * Convention to have the arrow pointing upwards. 
        * The super-class's properties and operations are not mentioned again in the sub-classes.  
        * `#` before a property represents a `protected` member variable.
        * Types of Inheritance: 
            * Implementation Inheritance : Inheritance from another class or abstract class
            * Interface Inheritance : Inheriting an interface. Interface class name is preceded by `<<interface>>`. It is represented by a _dotted_ arrow with the interface at the head, the sub-class at the tail and arrow facing upwards.
                * Polymorphism : Means similar behavior different implementation. Interfaces help achieve that with different classes inheriting from it.
                * Interfaces can inherit from other interfaces. Used when the scope needs to be increased without breaking existing uses of an interface. The new interface can inherit the old one and new classes meant to increase the scope can inherit from the new interface.
- General Java Points:
    * Abstract classes can not be instantiated. 
    * Implementation inheritance between classes is declared using the `extends` keyword. Interface inheritance is declared using `implements` keyword.
    * Implicit Constructor : No constructor declared, member variables are initialized to the default value of their type or null.
   * Explicit Constructor : A constructor is explicitly declared for initializing the member variables. If an abstract class has an explicit constructor then it must be referenced in all sub-classes' constructors using the `super` keyword.
    * Super-class methods can be overridden in the subclasses. Override keyword is _not_ required.
    * Only one implementation inheritance is allowed in a class. Multiple interface inheritance is allowed.  
    * Access Modifiers in Java:
        * Public : Everyone can access
        * Protected : Subclass + Within the package. 
        * Default : Within the pacakge. 
        * Private : Within the class only.

## Module 3 : Design Principles 
- Evaluating Design Complexity: In a good design, various modules are compatible with each other. Can be easily connected and re-used. Metrics for evaluating design complexity: 
    * Coupling: Complexity _between_ modules. If a module is too reliant on other module => tight coupling => bad design. If a module easily connects to otehr modules (well-defined interface) => lose coupling => good design. Metrics to evaluate coupling:
        * Degree : Number of connections between modules. For losely coupled, number of connections should be small, i.e. connections are amde with few paramaters and narrow interfaces.
        * Ease : Easy and obvious connections. Modules should connect with each other easily  i.e. without any knowledge of each other's implementation.
        * Flexibility : Other modules, connected to a module, must be easily replaceable. Ability to replace them for better versions.
    * Cohesion: Complexity _within_ a module; represents clarity in responsibilities of a module.
        * High Cohesion: A module preforms one task and nothing else. Has a clear responsibility. 
        * Low Cohesion: A module tries to encapsulate too many responsibilities; module has unclear purpose. 
        * High cohesion, good design. Low cohesion, bad design. 
        * If a module has two or more responsibilities, then split the module. 
    * Balance between coupling and cohesion: A module with a single purpose (high cohesion) will need to rely on many modules (tight coupling). A modlue with low cohesion will rely on less modules (lose coupling). Blance b/w the two is important. 
- Seperation of Concerns: 
    * Concern is anything tha matters in providing a solution to the problem. 
    * Different concerns(sub-pproblems) should be addresed in different protions of the software. 
    * Advantages: Different sections of a software can be implemented/ updated independently. Different sections need not know _how_ other sections work. 
    * Seperation of concern is strongly related to the design principles: Abstraction, Encapsulation, Decomposition and Generalization can all be achieved by properly separating out concerns. 
    * Seperation of Concerns is an ongoing process in sfotware development. How to properly separate out concerns is at the core ofdesigning modular software. 
    * Good smartphone example in text. 
- Informatio Hiding:
    * Closely related to ecapsulation. 
    * A module should only have access to information that it needs to do its job. 
    * _Rule of Thumb_: This that might change (algorithms, etc.) must be hidden. Things that do not change (assumptions) must be exposed through APIs and interfaces.
    * Information hiding achieved through access modifiers. See `General Java Points` on access modifiers.  
- Conceptual Integrity: Guidelines for making consistent software. Solution should be cohesive and appear as if a single developer worked on it. Guidelines:
    * Communication with all team members: Agile development. Sprint meetings. 
    * Code Reviews and Commit Reviews (small group of ppl reviewing commits to the master)
    * Well defined underlying software
    * Agreeing on design principles and coding constructs: `Design Patterns` help with this
    * Unifying Concepts: 
        * Finding commonalities between dfiferent concpets in the solution so that they can be treated in similar ways.
        * Avoids special cases: It better to omit anomolous features and reflect consistent set of concepts in a software.
- Generalization Principles: Inheritence is among the more difficult concepts to master in object oriented design. Misuse of inheritance can ead to poorly designed code. Following are principles to ensure inheritance is not being misused:
    * *Is inhertitance being used only to share attributes without adding any specialization in sub-classes?* If *yes* inheritence is being *misused*
    * Liskov Substitution Principle:
        * *Functions that use pointers to base classes must be able to use objects of derived classes without knowing about it*
        * Sub-classes should satisfy constraints and contracts set by the parent class. 
        * `is-a` technique for inheritance although useful, often results in bad inheritance 
        * Example: `Penguin` is-a `bird`. But penguin can't fly. Making penguin inherit from bird will lead to an empyty override of `fly` method. Special checks are required in other places in the solution to check if an instance of `bird` is a `penguin`; violating LSP. 
        * *If an override method does nothing or throws an exception; LSP is being violated*
        * Good explanation here : https://www.tomdalling.com/blog/software-design/solid-class-design-the-liskov-substitution-principle/
    * Cases where inheritance seems inappropriate; decomposition may be the solution. Example: Separate Bird class into FlyingBirds and NonFlylingBirds. Penguin class inherits from NonFlyingBirds. 
- Specialized UML Class Diagrams:
    * UML Sequence Diagrams: 
        * Show how objects in a program interact with each other to complete tasks. 
        * Sequence diagrams are used as planing tool before dev team starts programming. 
        * Components of sequence diagram:
            * Objects are represented by boxes. The names (roles) are the class names for the object.
            * Vertical dotted lines represent _lifelines_; state of the object as time goes by. 
            * Solid horizontal arrows represent messages b/w sender and receiver. Receiver at the arrow had; message description at the top. 
            * Dotted horizontal arrow represents return of data or control back to an object. 
            * Rectangels represent activation of objects. Rectangle covers the lifelines whenever an object sends or receives a message. 
            * Users are represented by stick figures; called actors in sequence diagrams. 
        * if-else represented by alt-else; loops are also possible, typically present as a sequence diagram within the main sequence diagram.
    * UML State Diagram: Depict the changing state of an object.
        * State of an object is determined by values of its attributes
        * State changes are triggered by events
        * Components of state diagrams:
            * Start: Filled cirle
            * State: Components of a state:
                * State name: short description
                * State Variable: Data relevant to the state 
                * Activities: Actions performed in the state. Three categories:
                    * Entry Activities: Actions that occur when a state is entered
                    * Exit Activities: Actions that occur when a state is exited
                    * Do Activities: Actions that occur when in the state.
            * Transition : Represented by arrows. Define the event, condition and action on top of the arrow.
            * Termination : End of state diagram, if not a continuous process. Circle with a filled circle.   
        * Benefits: Help determine the events in an objects lifetime. Help create __Model Checking__ tests.
        
        



       





        


         


