describe('Application router', function () {
  beforeEach(function () {
    this.router = new KnowYourLore.ApplicationRouter();
    this.indexRouteStub = sinon.stub(this.router, 'index');

    Backbone.history.start({silent: true, pushState: true});
    this.router.navigate('elsewhere', {trigger: true});
  });

  afterEach(function () {
    Backbone.history.stop();
    this.indexRouteStub.restore();
    this.router.navigate('elsewhere', {trigger: true});
  });

  it('Has the right amount of routes', function() {
    expect(_.size(this.router.routes)).toEqual(1);
  });

  it('/ -route exists and points to the right method', function () {
    expect(this.router.routes['']).toEqual('index');
  });

  it('calls the index route by navigating to /', function () {
    this.router.bind('route:index', this.indexRouteStub, this);
    this.router.navigate('/', {trigger: true});

    expect(this.indexRouteStub.called).toBe(true);
  })
});