$('[placeholder]').focus(function() {
  var input = $(this);
  if (input.val() == input.attr('placeholder')) {
    if (this.originalType) {
      this.type = this.originalType;
      delete this.originalType;
    }
    input.val('');
    input.removeClass('placeholder');
  }
}).blur(function() {
  var input = $(this);
  if (input.val() == '') {
    if (this.type == 'password') {
      this.originalType = this.type;
      this.type = 'text';
    }
    input.addClass('placeholder');
    input.val(input.attr('placeholder'));
  }
}).blur();