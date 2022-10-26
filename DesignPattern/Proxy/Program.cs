using Proxy.ProtectionProxy;

ICar car = new CarProxy(new Driver(12)); // 22
car.Drive();