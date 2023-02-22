// Задача с собакой, когда друзья движутся навстречу друг другу

int count = 0;
double distance = 100;
double FirstFriendSpeed = 1;
double SecondFriendSpeed = 2;
double DogSpeed = 3;
int friend = 2;
double time = 0;

while(distance > 1)
{
  if(friend == 2)
  {
    time = distance / (SecondFriendSpeed + DogSpeed);
    friend = 1;
  }
  time = distance / (FirstFriendSpeed + DogSpeed);
  friend = 2;
  
  distance = distance - (SecondFriendSpeed + FirstFriendSpeed) * time;

  count = count + 1;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
