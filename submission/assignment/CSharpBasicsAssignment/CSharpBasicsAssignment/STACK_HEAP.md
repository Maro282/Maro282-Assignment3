![[OrderClass.png|434]]

### Diagram 1

```
Order o1 = new Order()
{
    OrderId = 1,
    CustomerName = "Marwan"
};
```

![[images/diagram.png|364]]

In this step o1 reference to the object located in the heap by storing the address of that obj

### Diagram 2

```
Order o2 = o1;
```


![[images/diagram 2.png|399]]

In this step assigning o1 to o2 copy the reference from o1 to o2 so two variables point to the same obj in heap 

### Diagram 3

```
o2.IsPaid = true;
```

![[images/diagram 3.png|425]]

any change in the object state from anyone of references will be visible through the other reference too because they point to the same obj 


### What would be different with structs?

If `Order` were a struct instead of a class, it would be a value type. Assigning `Order o2 = o1` would copy the value of `o1` into `o2`, creating an independent copy. Therefore, changing `o2.IsPaid` would not affect `o1.IsPaid`. This is the same behavior demonstrated with the `Point` struct in Part C.
