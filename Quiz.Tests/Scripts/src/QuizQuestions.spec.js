describe('QuizQuestions', function () {
  beforeEach(function () {
    this.collection = new KnowYourLore.QuizQuestions();

    this.response = [
      {
        questionId: 0,
        question: 'some question',
        answers: [
          'answer 1',
          'answer 2',
          'answer 3'
        ]
      },
      {
        questionId: 1,
        question: 'some other question',
        answers: [
          'answer 1',
          'answer 2'
        ]
      }
    ];

  });

  afterEach(function () {

  });

  it('initialises with an empty collection', function () {
    expect(this.collection.length).toBe(0);
  });

  describe('fetch questions from server', function () {
    beforeEach(function () {
      this.server = sinon.fakeServer.create();
      var url = "/quiz/some-id";
      this.server.respondWith("GET", url,
          [200, { "Content-Type": "application/json" },
            JSON.stringify(this.response)]);
      this.collection.url = url;
      this.collection.fetch();
      this.server.respond();
    });

    afterEach(function () {
      this.server.restore();
    });

    it('populates the collection from the response', function () {
      expect(this.collection.length).toBe(2);
    });

    it('sets the correct questionId', function () {
      var model = this.collection.at(0);

      expect(model.get('questionId')).toBe(this.response[0].questionId);
    });

    it('sets the correct question from the response', function () {
      var model = this.collection.at(0);
      expect(model.get('question')).toBe(this.response[0].question);
    });

    it('sets the correct collection of answers for the question from the response', function () {
      var model = this.collection.at(0);

      expect(model.get('answers').length).toBe(this.response[0].answers.length);
    });
  });

  describe('askForNewQuiz', function () {
    beforeEach(function () {
      this.collectionStub = sinon.stub(this.collection, 'fetch');
      this.server = sinon.fakeServer.create();
    });

    afterEach(function () {
      this.server.restore();
      this.collection.fetch.restore();
    });

    it('sets the collection URI with the response header value from the service and calls fetch', function (done) {

      var url = "/quiz/";
      this.server.respondWith("POST", url,
          [201, { "Content-Type": "application/json",
            "Location": url + "some-id" },
            'null']);
      this.collection.askForNewQuiz();
      this.server.respond();

      expect(this.collection.url).toBe(url + "some-id");
      expect(this.collectionStub.calledOnce).toBe(true);
    });
  });

});