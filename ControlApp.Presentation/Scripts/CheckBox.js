+function (a) { "use strict"; function b(b) { return this.each(function () { var d = a(this), e = d.data("bs.toggle"), f = "object" == typeof b && b; e || d.data("bs.toggle", e = new c(this, f)), "string" == typeof b && e[b] && e[b]() }) } var c = function (b, c) { this.$element = a(b), this.options = a.extend({}, this.defaults(), c), this.render() }; c.VERSION = "2.2.0", c.DEFAULTS = { on: "On", off: "Off", onstyle: "primary", offstyle: "default", size: "normal", style: "", width: null, height: null }, c.prototype.defaults = function () { return { on: this.$element.attr("data-on") || c.DEFAULTS.on, off: this.$element.attr("data-off") || c.DEFAULTS.off, onstyle: this.$element.attr("data-onstyle") || c.DEFAULTS.onstyle, offstyle: this.$element.attr("data-offstyle") || c.DEFAULTS.offstyle, size: this.$element.attr("data-size") || c.DEFAULTS.size, style: this.$element.attr("data-style") || c.DEFAULTS.style, width: this.$element.attr("data-width") || c.DEFAULTS.width, height: this.$element.attr("data-height") || c.DEFAULTS.height } }, c.prototype.render = function () { this._onstyle = "btn-" + this.options.onstyle, this._offstyle = "btn-" + this.options.offstyle; var b = "large" === this.options.size ? "btn-lg" : "small" === this.options.size ? "btn-sm" : "mini" === this.options.size ? "btn-xs" : "", c = a('<label class="btn">').html(this.options.on).addClass(this._onstyle + " " + b), d = a('<label class="btn">').html(this.options.off).addClass(this._offstyle + " " + b + " active"), e = a('<span class="toggle-handle btn btn-default">').addClass(b), f = a('<div class="toggle-group">').append(c, d, e), g = a('<div class="toggle btn" data-toggle="toggle">').addClass(this.$element.prop("checked") ? this._onstyle : this._offstyle + " off").addClass(b).addClass(this.options.style); this.$element.wrap(g), a.extend(this, { $toggle: this.$element.parent(), $toggleOn: c, $toggleOff: d, $toggleGroup: f }), this.$toggle.append(f); var h = this.options.width || Math.max(c.outerWidth(), d.outerWidth()) + e.outerWidth() / 2, i = this.options.height || Math.max(c.outerHeight(), d.outerHeight()); c.addClass("toggle-on"), d.addClass("toggle-off"), this.$toggle.css({ width: h, height: i }), this.options.height && (c.css("line-height", c.height() + "px"), d.css("line-height", d.height() + "px")), this.update(!0), this.trigger(!0) }, c.prototype.toggle = function () { this.$element.prop("checked") ? this.off() : this.on() }, c.prototype.on = function (a) { return this.$element.prop("disabled") ? !1 : (this.$toggle.removeClass(this._offstyle + " off").addClass(this._onstyle), this.$element.prop("checked", !0), void (a || this.trigger())) }, c.prototype.off = function (a) { return this.$element.prop("disabled") ? !1 : (this.$toggle.removeClass(this._onstyle).addClass(this._offstyle + " off"), this.$element.prop("checked", !1), void (a || this.trigger())) }, c.prototype.enable = function () { this.$toggle.removeAttr("disabled"), this.$element.prop("disabled", !1) }, c.prototype.disable = function () { this.$toggle.attr("disabled", "disabled"), this.$element.prop("disabled", !0) }, c.prototype.update = function (a) { this.$element.prop("disabled") ? this.disable() : this.enable(), this.$element.prop("checked") ? this.on(a) : this.off(a) }, c.prototype.trigger = function (b) { this.$element.off("change.bs.toggle"), b || this.$element.change(), this.$element.on("change.bs.toggle", a.proxy(function () { this.update() }, this)) }, c.prototype.destroy = function () { this.$element.off("change.bs.toggle"), this.$toggleGroup.remove(), this.$element.removeData("bs.toggle"), this.$element.unwrap() }; var d = a.fn.bootstrapToggle; a.fn.bootstrapToggle = b, a.fn.bootstrapToggle.Constructor = c, a.fn.toggle.noConflict = function () { return a.fn.bootstrapToggle = d, this }, a(function () { a("input[type=checkbox][data-toggle^=toggle]").bootstrapToggle() }), a(document).on("click.bs.toggle", "div[data-toggle^=toggle]", function (b) { var c = a(this).find("input[type=checkbox]"); c.bootstrapToggle("toggle"), b.preventDefault() }) }(jQuery);

+function ($) {
    'use strict';


    var Toggle = function (element, options) {
        this.$element = $(element)
        this.options = $.extend({}, this.defaults(), options)
        this.render()
    }

    Toggle.VERSION = '2.2.0'

    Toggle.DEFAULTS = {
        on: 'On',
        off: 'Off',
        onstyle: 'primary',
        offstyle: 'default',
        size: 'normal',
        style: '',
        width: null,
        height: null
    }

    Toggle.prototype.defaults = function () {
        return {
            on: this.$element.attr('data-on') || Toggle.DEFAULTS.on,
            off: this.$element.attr('data-off') || Toggle.DEFAULTS.off,
            onstyle: this.$element.attr('data-onstyle') || Toggle.DEFAULTS.onstyle,
            offstyle: this.$element.attr('data-offstyle') || Toggle.DEFAULTS.offstyle,
            size: this.$element.attr('data-size') || Toggle.DEFAULTS.size,
            style: this.$element.attr('data-style') || Toggle.DEFAULTS.style,
            width: this.$element.attr('data-width') || Toggle.DEFAULTS.width,
            height: this.$element.attr('data-height') || Toggle.DEFAULTS.height
        }
    }

    Toggle.prototype.render = function () {
        this._onstyle = 'btn-' + this.options.onstyle
        this._offstyle = 'btn-' + this.options.offstyle
        var size = this.options.size === 'large' ? 'btn-lg'
            : this.options.size === 'small' ? 'btn-sm'
                : this.options.size === 'mini' ? 'btn-xs'
                    : ''
        var $toggleOn = $('<label class="btn">').html(this.options.on)
            .addClass(this._onstyle + ' ' + size)
        var $toggleOff = $('<label class="btn">').html(this.options.off)
            .addClass(this._offstyle + ' ' + size + ' active')
        var $toggleHandle = $('<span class="toggle-handle btn btn-default">')
            .addClass(size)
        var $toggleGroup = $('<div class="toggle-group">')
            .append($toggleOn, $toggleOff, $toggleHandle)
        var $toggle = $('<div class="toggle btn" data-toggle="toggle">')
            .addClass(this.$element.prop('checked') ? this._onstyle : this._offstyle + ' off')
            .addClass(size).addClass(this.options.style)

        this.$element.wrap($toggle)
        $.extend(this, {
            $toggle: this.$element.parent(),
            $toggleOn: $toggleOn,
            $toggleOff: $toggleOff,
            $toggleGroup: $toggleGroup
        })
        this.$toggle.append($toggleGroup)

        var width = this.options.width || Math.max($toggleOn.outerWidth(), $toggleOff.outerWidth()) + ($toggleHandle.outerWidth() / 2)
        var height = this.options.height || Math.max($toggleOn.outerHeight(), $toggleOff.outerHeight())
        $toggleOn.addClass('toggle-on')
        $toggleOff.addClass('toggle-off')
        this.$toggle.css({ width: width, height: height })
        if (this.options.height) {
            $toggleOn.css('line-height', $toggleOn.height() + 'px')
            $toggleOff.css('line-height', $toggleOff.height() + 'px')
        }
        this.update(true)
        this.trigger(true)
    }

    Toggle.prototype.toggle = function () {
        if (this.$element.prop('checked')) this.off()
        else this.on()
    }

    Toggle.prototype.on = function (silent) {
        if (this.$element.prop('disabled')) return false
        this.$toggle.removeClass(this._offstyle + ' off').addClass(this._onstyle)
        this.$element.prop('checked', true)
        if (!silent) this.trigger()
    }

    Toggle.prototype.off = function (silent) {
        if (this.$element.prop('disabled')) return false
        this.$toggle.removeClass(this._onstyle).addClass(this._offstyle + ' off')
        this.$element.prop('checked', false)
        if (!silent) this.trigger()
    }

    Toggle.prototype.enable = function () {
        this.$toggle.removeAttr('disabled')
        this.$element.prop('disabled', false)
    }

    Toggle.prototype.disable = function () {
        this.$toggle.attr('disabled', 'disabled')
        this.$element.prop('disabled', true)
    }

    Toggle.prototype.update = function (silent) {
        if (this.$element.prop('disabled')) this.disable()
        else this.enable()
        if (this.$element.prop('checked')) this.on(silent)
        else this.off(silent)
    }

    Toggle.prototype.trigger = function (silent) {
        this.$element.off('change.bs.toggle')
        if (!silent) this.$element.change()
        this.$element.on('change.bs.toggle', $.proxy(function () {
            this.update()
        }, this))
    }

    Toggle.prototype.destroy = function () {
        this.$element.off('change.bs.toggle')
        this.$toggleGroup.remove()
        this.$element.removeData('bs.toggle')
        this.$element.unwrap()
    }

    // TOGGLE PLUGIN DEFINITION
    // ========================

    function Plugin(option) {
        return this.each(function () {
            var $this = $(this)
            var data = $this.data('bs.toggle')
            var options = typeof option == 'object' && option

            if (!data) $this.data('bs.toggle', (data = new Toggle(this, options)))
            if (typeof option == 'string' && data[option]) data[option]()
        })
    }

    var old = $.fn.bootstrapToggle

    $.fn.bootstrapToggle = Plugin
    $.fn.bootstrapToggle.Constructor = Toggle

    // TOGGLE NO CONFLICT
    // ==================

    $.fn.toggle.noConflict = function () {
        $.fn.bootstrapToggle = old
        return this
    }

    // TOGGLE DATA-API
    // ===============

    $(function () {
        $('input[type=checkbox][data-toggle^=toggle]').bootstrapToggle()
    })

    $(document).on('click.bs.toggle', 'div[data-toggle^=toggle]', function (e) {
        var $checkbox = $(this).find('input[type=checkbox]')
        $checkbox.bootstrapToggle('toggle')
        e.preventDefault()
    })

}(jQuery);

$(function () {
    $('#toggle-two').bootstrapToggle({
        on: 'Enabled',
        off: 'Disabled'
    });
})

if (button.text() == "Apply") {
    if ($("#selectLocation").is(':checked'))
        button.removeAttr("disabled");
    else
        button.attr("disabled", "disabled");
}

$(document).ready(function () {
    $('a#myButton').click(function () {
        $(this).toggleClass("btnClicked");
    });
});