# StudentSolution
- What did you learn?
    - How to manage maintaining order in a multi-purpose queue.
    - I came into this using just the problem domain.  No help or research used.
- Did you write anything down, bookmark anything that looked useful?
    - We whiteboarded it out and my partner suggested a great solution that used just one queue.  His Solution was simple and easy to implement.
- What did you use as a guideline or direction during the challenge?
    - Just my experience and my partners.  Code written is 100% mine. Works as intended.
    
- Forgot to take a picture of our whiteboard, so I'll describe the steps we took to implement our solution.
  - If no preference on species, dequeue and return front of queue.
  - If preference, if desired species is at front of queue, dequeue and return front.
  - Else, save reference to Animal in front of queue, dequeue animals until desired species is available,  save that animal to a return value.
  - Continue dequeuing and enqueuing animals back out of and back into the same queue until the original animal is back at the front of the queue.
  - thus preserving the order of the queue minus the desired animal.
  - return the desired animal.
