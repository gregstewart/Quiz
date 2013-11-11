var Quiz = Quiz || {};

Quiz.QuizQuestions = Backbone.Collection.extend({
  url: '/quiz/',

  askForNewQuiz: function () {
    var self = this;
    resp = this.create();
    resp.on('sync', function () {
      self.url = arguments[2].xhr.getResponseHeader('Location');
    });
  }

});