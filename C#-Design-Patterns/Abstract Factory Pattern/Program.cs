using Abstract_Factory_Pattern;

ICarFactory factory = new BmwFactory();

IEngine engine = factory.CreateEngine();
ITire tire = factory.CreateTire();

engine.Build();
tire.Build();