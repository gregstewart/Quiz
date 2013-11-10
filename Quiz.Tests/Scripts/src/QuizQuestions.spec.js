describe('QuizQuestions', function () {
   beforeEach(function () {
     this.collection = new Quiz.QuizQuestions();
     this.response = [
       {
         questionId: 0,
         question: 'some question',
         answers: [
          'answer 1',
          'answer 2',
          'answer 3'
         ]
       }
     ];
   });

  afterEach(function () {
  });

  it('initialises with an empty collection', function() {
    expect(this.collection.length).toBe(0);
  });

  describe('fetch questions from server', function () {
     beforeEach(function () {
       this.server = sinon.fakeServer.create();
       this.server.respondWith("GET", "/quiz/some-id",
           [200, { "Content-Type": "application/json" },
             JSON.stringify(this.response)]);
       this.collection.fetch();
       this.server.respond();
     });

    afterEach(function () {
      this.server.restore();
    });

    it('populates the collection from the response', function () {
      expect(this.collection.length).toBe(1);

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


});